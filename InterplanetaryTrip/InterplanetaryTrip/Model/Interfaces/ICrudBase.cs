using InterplanetaryTrip.Model.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.Interfaces
{
    interface ICrudBase<T>
    {
        void Cadastrar(T entidade, string procedure);
       
        List<T> Consultar(string procedure, dynamic parametro, string CampoConsulta);

        void Alterar(T entidade, string procedure);

        void Remover(string procedure, dynamic valorRemocao, string campoRemocao);
    }
}
