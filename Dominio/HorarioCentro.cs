using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HorarioCentro
    {
        public int ID { get; set; }
        public CentroDeporte Centro { get; set; }
        public int HoraDesde { get; set; }
        public int HoraHasta { get; set; }
        public decimal DuracionJuego { get; set; }
    }
}
