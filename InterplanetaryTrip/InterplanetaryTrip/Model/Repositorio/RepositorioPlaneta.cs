//using InterplanetaryTrip.Model.Entidades;
//using InterplanetaryTrip.Model.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using InterplanetaryTrip.Model.DB;

//namespace InterplanetaryTrip.Model.Repositorio
//{
//    class RepositorioPlaneta : ICrudBase<Planeta>
//    {
//        Conexao db = new Conexao();

//        public void Alterar(Planeta planeta, string nome)
//        {
//            SqlDataReader reader = db.Consulta("planeta_spi", new List<SqlParameter>
//            {
//                new SqlParameter("@Nome", planeta.Nome),
//                new SqlParameter("@Descricao", planeta.Descricao),
//                new SqlParameter("@PossuiOxigenio", planeta.PossuiOxigênio),
//                new SqlParameter("@NomePlanetaParaTroca", nome)
//            });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }

//        public void Cadastrar(Planeta planeta)
//        {
//            SqlDataReader reader = db.Consulta("planeta_spi", new List<SqlParameter>
//            {
//                new SqlParameter("@Nome", planeta.Nome),
//                new SqlParameter("@Descricao", planeta.Descricao),
//                new SqlParameter("@PossuiOxigenio", planeta.PossuiOxigênio)
//            });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }

//        public List<Planeta> Consultar(string Nome)
//        {
//            SqlDataReader reader = db.Consulta("planeta_sps", new List<SqlParameter> { new SqlParameter("@Nome", Nome) });
//            var Planetas = new List<Planeta>();
//            while (reader.Read())
//            {
//                Console.WriteLine("Id: {0}, Nome: {1}", reader["Id"], reader["Nome"]);
//                Planetas.Add(new Planeta(
//                    Convert.ToInt32(reader["Id"]),
//                    Convert.ToString(reader["Nome"]),
//                    Convert.ToString(reader["Descricao"]),
//                    Convert.ToBoolean(reader["PossuiOxigenio"])));
//            }

//            return Planetas;
//        }

//        public List<Planeta> Consultar(string Nome, int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Remover(string Nome)
//        {
//            SqlDataReader reader = db.Consulta("planeta_spd", new List<SqlParameter> { new SqlParameter("@Nome", Nome) });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);

//            }
//        }
//    }
//}
