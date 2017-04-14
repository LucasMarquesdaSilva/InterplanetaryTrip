//using InterplanetaryTrip.Model.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using InterplanetaryTrip.Model.classes;
//using System.Data.SqlClient;
//using InterplanetaryTrip.Model.DB;

//namespace InterplanetaryTrip.Model.Repositorio
//{
//    class RepositorioCliente : ICrudBase<Cliente>
//    {

//        Conexao db = new Conexao();


//        public void Alterar(Cliente cliente, string nome)
//        {
//            SqlDataReader reader = db.Consulta("especie_spi", new List<SqlParameter>
//            {
//                new SqlParameter("@Nome", cliente.Nome),
//                new SqlParameter("@Documento", cliente.Documento),
//                new SqlParameter("@Cor", cliente.Cor),
//                new SqlParameter("@QtdBracos", cliente.QtdBracos),
//                new SqlParameter("@QtdPernas", cliente.QtdPernas),
//                new SqlParameter("@QtdCabeca", cliente.QtdCabeca),
//                new SqlParameter("@Respira", cliente.Respira),
//                new SqlParameter("@NomeParaTroca", nome)
//            });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }

//        public void Cadastrar(Cliente cliente)
//        {
//            SqlDataReader reader = db.Consulta("especie_spi", new List<SqlParameter>
//            {
//                new SqlParameter("@Nome", cliente.Nome),
//                new SqlParameter("@Documento", cliente.Documento),
//                new SqlParameter("@Cor", cliente.Cor),
//                new SqlParameter("@QtdBracos", cliente.QtdBracos),
//                new SqlParameter("@QtdPernas", cliente.QtdPernas),
//                new SqlParameter("@QtdCabeca", cliente.QtdCabeca),
//                new SqlParameter("@Respira", cliente.Respira)
//            });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }

//        public List<Cliente> Consultar(string Nome)
//        {
//            SqlDataReader reader = db.Consulta("especie_sps", new List<SqlParameter> { new SqlParameter("@Nome", Nome) });
//            var Clientes = new List<Cliente>();
//            while (reader.Read())
//            {
//                Console.WriteLine("Id: {0}, Nome: {1}", reader["Id"], reader["Nome"]);
//                Clientes.Add(new Cliente(
//                    Convert.ToInt32(reader["Id"]),
//                    Convert.ToString(reader["Nome"]),
//                    Convert.ToString(reader["Documento"]),
//                    Convert.ToString(reader["TipoEspecie"]),
//                    Convert.ToString(reader["Cor"]),
//                    Convert.ToInt32(reader["QtdBracos"]),
//                    Convert.ToInt32(reader["QtdPernas"]),
//                    Convert.ToInt32(reader["QtdCabecas"]),
//                    Convert.ToBoolean(reader["Respira"])));
//            }

//            return Clientes;
//        }

//        public List<Cliente> Consultar(string Nome, int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Remover(string Nome)
//        {
//            SqlDataReader reader = db.Consulta("especie_spd", new List<SqlParameter> { new SqlParameter("@Nome", Nome) });
//            while(reader.Read()){
//                Console.WriteLine(reader["Mensagem"]);

//            }

//        }

//    }
//}
