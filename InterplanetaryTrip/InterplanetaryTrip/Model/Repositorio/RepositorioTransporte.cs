//using InterplanetaryTrip.Model.DB;
//using InterplanetaryTrip.Model.Entidades;
//using InterplanetaryTrip.Model.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InterplanetaryTrip.Model.Repositorio
//{
//    class RepositorioTransporte : ICrudBase<Transporte>
//    {
//        Conexao db = new Conexao();


//        public void Alterar(Transporte transporte, string nome)
//        {
//            SqlDataReader reader = db.Consulta("transporte_spu", new List<SqlParameter>
//            {
//                new SqlParameter("@Nome", transporte.Nome),
//                new SqlParameter("@Terreno", transporte.Terreno),
//                new SqlParameter("@NomeTransporteParaTroca", nome)
//            });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }

//        public void Cadastrar(Transporte transporte)
//        {

//            SqlDataReader reader = db.Consulta("transporte_spi", new List<SqlParameter>
//            {
//                new SqlParameter("@Nome", transporte.Nome),
//                new SqlParameter("@Terreno", transporte.Terreno)
//            });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }

//        public List<Transporte> Consultar(string Nome)
//        {
//            SqlDataReader reader = db.Consulta("transporte_spi", new List<SqlParameter> { new SqlParameter("@Nome", Nome) });
//            var Transportes = new List<Transporte>();
//            while (reader.Read())
//            {
//                Console.WriteLine("Id: {0}, Nome: {1}", reader["Id"], reader["Nome"]);
//                Transportes.Add(new Transporte(
//                    Convert.ToInt32(reader["Id"]),
//                    Convert.ToString(reader["Nome"]),
//                    Convert.ToString(reader["Terreno"])));
//            }

//            return Transportes;
//        }

//        public List<Transporte> Consultar(string Nome, int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Remover(string Nome)
//        {
//            SqlDataReader reader = db.Consulta("transporte_spd", new List<SqlParameter> { new SqlParameter("@Nome", Nome) });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }
//    }
//}
