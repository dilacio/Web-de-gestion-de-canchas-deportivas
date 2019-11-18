using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HorarioCancha
    {
        public int ID { get; set; }
        public Cancha Cancha { get; set; }
        public TimeSpan HoraDesde { get; set; }
        public TimeSpan HoraHasta { get; set; }
        public TimeSpan Duracion { get; set; }
    }
}
