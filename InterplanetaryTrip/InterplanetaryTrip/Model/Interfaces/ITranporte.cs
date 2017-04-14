using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.Interfaces
{
    interface ITranporte
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Terreno { get; set; }
    }
}
