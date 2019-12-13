using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Reserva
    {
        public int ID { get; set; }
        public Cancha Cancha { get; set; }
        public Actividad Actividad { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraDesde { get; set; }
        public TimeSpan HoraHasta { get; set; }
        public Usuario Usuario { get; set; }
        public EstadoReserva Estado { get; set; }

    }
}
