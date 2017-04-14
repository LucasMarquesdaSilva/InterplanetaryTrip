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
//    class RepositorioViagem : ICrudBase<Viagem>
//    {
//        Conexao db = new Conexao();

//        public void Alterar(Viagem viagem, string nome)
//        {
//            SqlDataReader reader = db.Consulta("viagem_spu", new List<SqlParameter>
//            {
//                new SqlParameter("@IdPlanetaOrigem", viagem.IdPlanetaOrigem),
//                new SqlParameter("@IdPlanetaDestino", viagem.IdPlanetaDestino),
//                new SqlParameter("@IdCliente", viagem.IdPCliente),
//                new SqlParameter("@Valor", viagem.valor),
//                new SqlParameter("@Tempo", viagem.Tempo)
//            });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }

//        public void Cadastrar(Viagem viagem)
//        {
//            SqlDataReader reader = db.Consulta("viagem_spi", new List<SqlParameter>
//            {
//                new SqlParameter("@IdPlanetaOrigem", viagem.IdPlanetaOrigem),
//                new SqlParameter("@IdPlanetaDestino", viagem.IdPlanetaDestino),
//                new SqlParameter("@IdCliente", viagem.IdPCliente),
//                new SqlParameter("@Valor", viagem.valor),
//                new SqlParameter("@Tempo", viagem.Tempo)
//            });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }

//        public List<Viagem> Consultar(string Nome, int id)
//        {
//            throw new NotImplementedException();
//        }

//        //public List<Viagem> Consultar(string Nome, int Id)
//        //{
//        //    SqlDataReader reader = db.Consulta("viagem_sps", new List<SqlParameter> { new SqlParameter("@Id", Id) });
//        //    var Viagens = new List<Viagem>();
//        //    while (reader.Read())
//        //    {
//        //        Console.WriteLine("Id: {0}, Nome: {1}", reader["Id"], reader["Nome"]);
//        //        Viagens.Add(new Viagem(
//        //            Convert.ToInt32(reader["Id"]),
//        //            Convert.ToString(reader["Nome"]),
//        //            Convert.ToInt32(reader["Documento"]),
//        //            Convert.ToInt32(reader["Respira"]),
//        //            Convert.ToDouble(reader["PlanetaOrigem"]),
//        //            Convert.ToString(reader["PlanetaDestino"])
//        //            ));
//        //    }

//        //    return Viagens;
//        //}

//        public void Remover(string Nome)
//        {
//            SqlDataReader reader = db.Consulta("viagem_spd", new List<SqlParameter> { new SqlParameter("@Nome", Nome) });
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Mensagem"]);
//            }
//        }
//    }
//}
