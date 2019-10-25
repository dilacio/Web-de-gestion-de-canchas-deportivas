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
        public CentroDeporte Centro { get; set; }
        public Actividad Actividad { get; set; }
        public HorarioCentro Horario { get; set; }
        public Pago Pago { get; set; }
        public Usuario Usuario { get; set; }
        public EstadoReserva Estado { get; set; }
    }
}
