﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Factura
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public float Importe { get; set; }
        public string Estado { get; set; }
    }
}
