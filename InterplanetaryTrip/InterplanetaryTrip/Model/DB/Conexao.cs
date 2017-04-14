using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.DB
{
    class Conexao
    {
        public SqlConnection ObterConexao()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["InterplanetaryTripCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
        public SqlDataReader Consulta(string query, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = query;
            foreach (var item in parametros)
            {
                comando.Parameters.Add(item);

            }
            comando.Connection = ObterConexao();
            comando.Connection.Open();
            SqlDataReader reader = comando.ExecuteReader();
            return reader;
        }
    }
}
