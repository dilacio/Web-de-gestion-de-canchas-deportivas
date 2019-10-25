using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string CP { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
