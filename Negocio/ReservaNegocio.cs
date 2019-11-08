using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class ReservaNegocio
    {
        AccesoDatos Datos;
        public bool Reservar(Reserva Res)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("INSERT INTO RESERVAS VALUES ("+Res.Centro.ID+","+Res.Actividad.ID+","+Res.Horario.ID+","+Res.Usuario.IDUsuario+","+Res.Estado.ID+")");
                Datos.Ejecucion_Accion();

                return true;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public List<Reserva> Listar_X_Usuario(Usuario User)
        {
            List<Reserva> Lista = new List<Reserva>();
            AccesoDatos Datos = new AccesoDatos();
            Reserva Aux;

            try
            {
                Datos.SetearQuery("SELECT A.[ID],B.NOMBRE,C.Nombre,D.HORA_DESDE,D.HORA_HASTA,D.DURACIONJUEGO,F.DESCRIPCION FROM [TP_MATCHPOINT].[dbo].[Reservas] AS A JOIN Centros_Deportes AS B ON A.ID_Centro_Deporte = B.ID JOIN Actividades AS C ON A.ID_Actividad = C.ID JOIN HORARIOS AS D ON A.ID_Horario = D.ID JOIN Usuarios AS E ON A.ID_Usuario = E.ID JOIN Estado_Reserva AS F ON A.ID_Estado_Reserva = F.ID WHERE ID_Usuario = " + User.IDUsuario);
                Datos.EjecutarLector();

                while(Datos.Lector.Read())
                {
                    Aux = new Reserva();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Centro = new CentroDeporte();
                    Aux.Centro.Nombre = Datos.Lector.GetString(1);
                    Aux.Actividad = new Actividad();
                    Aux.Actividad.Nombre = Datos.Lector.GetString(2);
                    Aux.Horario = new HorarioCentro();
                    Aux.Horario.HoraDesde = Datos.Lector.GetInt32(3);
                    Aux.Horario.HoraHasta = Datos.Lector.GetInt32(4);
                    Aux.Horario.DuracionJuego = Datos.Lector.GetDouble(5);
                    Aux.Estado = new EstadoReserva();
                    Aux.Estado.Descripcion = Datos.Lector.GetString(6);

                    Lista.Add(Aux);
                }

                return Lista;    
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
