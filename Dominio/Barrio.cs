using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Barrio
    {
        public int ID { get; set; }
        public Localidad Localidad { get; set; }
        public string Nombre { get; set; }
    }
}
