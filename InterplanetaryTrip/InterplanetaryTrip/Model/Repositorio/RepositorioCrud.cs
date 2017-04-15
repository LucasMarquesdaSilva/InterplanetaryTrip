using InterplanetaryTrip.Model.DB;
using InterplanetaryTrip.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.Repositorio
{
    class RepositorioCrud<T> : ICrudBase<T>
    {
        private readonly Conexao _database;
        public RepositorioCrud()
        {
            _database = new Conexao();
        }

        public void Alterar(T entidade, string procedure)
        {
            var lista = new List<SqlParameter>();

            foreach (var propriedade in typeof(T).GetProperties())
            {
                lista.Add(new SqlParameter("@" + propriedade.Name, propriedade.GetValue(entidade)));
                Console.WriteLine(propriedade.ToString());
            };
            SqlDataReader reader = _database.Consulta(procedure, lista);
            while (reader.Read())
            {
                Console.WriteLine(reader["Mensagem"]);
            }
        }

        public void Cadastrar(T entidade, string procedure)
        {
            var lista = new List<SqlParameter>();

            foreach (var propriedade in typeof(T).GetProperties())
            {
                if (propriedade.Name.ToLower() != "id")
                {
                    lista.Add(new SqlParameter("@" + propriedade.Name, propriedade.GetValue(entidade)));
                }
            };
            SqlDataReader reader = _database.Consulta(procedure, lista);
            while (reader.Read())
            {
                Console.WriteLine(reader["Mensagem"]);
            }
        }
        public List<T> Consultar(string procedure, dynamic parametroConsulta, string CampoConsulta)
        {
            SqlDataReader reader = _database.Consulta(procedure, new List<SqlParameter> { new SqlParameter(CampoConsulta, parametroConsulta) });

            var listaT = new List<T>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var objeto = Activator.CreateInstance<T>();
                    foreach (var propriedade in typeof(T).GetProperties())
                    {
                        propriedade.SetValue(objeto, reader[propriedade.Name]);
                    }
                    listaT.Add(objeto);
                }
            }
            return listaT;
        }

        public void Remover(string procedure, dynamic valorRemocao, string campoRemocao)
        {
            SqlDataReader reader = _database.Consulta(procedure, new List<SqlParameter> { new SqlParameter(campoRemocao, valorRemocao) });
            while (reader.Read())
            {
                Console.WriteLine(reader["Mensagem"]);
            }

        }
    }
}