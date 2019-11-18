﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cancha
    {
        public int ID { get; set; }
        public CentroDeporte Centro { get; set; }
        public string Nombre { get; set; }
        public Actividad Actividad  { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
