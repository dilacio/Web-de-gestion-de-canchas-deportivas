using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pago
    {
        public int ID { get; set; }
        public EstadoPago EstdadpPago { get; set; }
        public Factura Factura { get; set; }
    }
}
