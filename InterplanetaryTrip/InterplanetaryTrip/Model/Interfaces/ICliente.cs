﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.Interfaces
{
    interface ICliente
    {
        int Id { get; set; }

        string Nome { get; set; }

        string Documento { get; set; }

    }
}
