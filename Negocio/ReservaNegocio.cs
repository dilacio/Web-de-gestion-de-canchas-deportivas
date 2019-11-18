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

        public List<Reserva> ListarPorCentro(CentroDeporte Centro)
        {
            try
            {


                List<Reserva> Lista = new List<Reserva>();
                Reserva Aux = new Reserva();
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("SELECT R.[ID] ,R.[ID_Cancha],C.nombre,R.[ID_Actividad],A.Nombre,R.[FECHA],R.[HORA_DESDE],R.[HORA_HASTA],R.[ID_Usuario],R.[ID_Estado_Reserva] ,er.DESCRIPCION,cen.NOMBRE , cen.direccion FROM [TP_MATCHPOINT].[dbo].[Reservas]  AS R JOIN CANCHAS AS C ON C.ID = R.ID_Cancha JOIN Actividades AS A ON A.ID = R.ID_Actividad JOIN Usuarios AS U ON U.ID = R.ID_Usuario JOIN Estado_Reserva AS ER ON ER.ID = R.ID_Estado_Reserva join Centros_Deportes as cen on cen.ID = c.ID_Centro WHERE R.id_estado_reserva = 1 and Cen.ID = " + Centro.ID);
                Datos.EjecutarLector();


                if (Datos.Lector.Read())
                {
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Cancha = new Cancha();
                    Aux.Cancha.ID = Datos.Lector.GetInt32(1);
                    Aux.Cancha.Nombre = Datos.Lector.GetString(2);
                    Aux.Actividad = new Actividad();
                    Aux.Actividad.ID = Datos.Lector.GetInt32(3);
                    Aux.Actividad.Nombre = Datos.Lector.GetString(4);
                    Aux.Fecha = Datos.Lector.GetDateTime(5);
                    Aux.HoraDesde = Datos.Lector.GetTimeSpan(6);
                    Aux.HoraHasta = Datos.Lector.GetTimeSpan(7);
                    Aux.Usuario = new Usuario();
                    Aux.Usuario.IDUsuario = Datos.Lector.GetInt32(8);
                    Aux.Estado = new EstadoReserva();
                    Aux.Estado.ID = Datos.Lector.GetInt32(9);
                    Aux.Estado.Descripcion = Datos.Lector.GetString(10);
                    Aux.Cancha.Centro = new CentroDeporte();
                    Aux.Cancha.Centro.Nombre = Datos.Lector.GetString(11);
                    Aux.Cancha.Centro.Direccion = Datos.Lector.GetString(12);

                    Lista.Add(Aux);

                }
                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
}
        public bool BajaReserva( int ReservaID)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("UPDATE reservas set ID_Estado_reserva = 0 where ID = " + ReservaID);
                Datos.Ejecucion_Accion();
                
                return true;
            }
            catch (Exception Ex)
            {

                return false;
            }
        }
        public List<Reserva> ListarPorUsuario(Usuario User)
        {
            try
            {
                List<Reserva> Lista = new List<Reserva>();
                Reserva Aux = new Reserva();
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("SELECT R.[ID] ,R.[ID_Cancha],C.nombre,R.[ID_Actividad],A.Nombre,R.[FECHA],R.[HORA_DESDE],R.[HORA_HASTA],R.[ID_Usuario],R.[ID_Estado_Reserva] ,er.DESCRIPCION,cen.NOMBRE , cen.direccion FROM [TP_MATCHPOINT].[dbo].[Reservas]  AS R JOIN CANCHAS AS C ON C.ID = R.ID_Cancha JOIN Actividades AS A ON A.ID = R.ID_Actividad JOIN Usuarios AS U ON U.ID = R.ID_Usuario JOIN Estado_Reserva AS ER ON ER.ID = R.ID_Estado_Reserva join Centros_Deportes as cen on cen.ID = c.ID_Centro WHERE R.id_estado_reserva = 1 and ID_Usuario = " + User.IDUsuario);
                Datos.EjecutarLector();


                if(Datos.Lector.Read())
                {
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Cancha = new Cancha();
                    Aux.Cancha.ID = Datos.Lector.GetInt32(1);
                    Aux.Cancha.Nombre = Datos.Lector.GetString(2);
                    Aux.Actividad = new Actividad();
                    Aux.Actividad.ID = Datos.Lector.GetInt32(3);
                    Aux.Actividad.Nombre = Datos.Lector.GetString(4);
                    Aux.Fecha = Datos.Lector.GetDateTime(5);
                    Aux.HoraDesde = Datos.Lector.GetTimeSpan(6);
                    Aux.HoraHasta = Datos.Lector.GetTimeSpan(7);
                    Aux.Usuario = new Usuario();
                    Aux.Usuario.IDUsuario = Datos.Lector.GetInt32(8);
                    Aux.Estado = new EstadoReserva();
                    Aux.Estado.ID = Datos.Lector.GetInt32(9);
                    Aux.Estado.Descripcion = Datos.Lector.GetString(10);
                    Aux.Cancha.Centro = new CentroDeporte();
                    Aux.Cancha.Centro.Nombre = Datos.Lector.GetString(11);
                    Aux.Cancha.Centro.Direccion = Datos.Lector.GetString(12);

                    Lista.Add(Aux);

                }
                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public bool Guardar(Reserva Reserva)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("insert into reservas values ("+Reserva.Cancha.ID+","+Reserva.Actividad.ID+ ",convert(DATETIME, '" + Reserva.Fecha + "', 103),'" + Reserva.HoraDesde+"','"+Reserva.HoraHasta+"',"+Reserva.Usuario.IDUsuario+",1);");
                Datos.Ejecucion_Accion();
                return true;
            }
            catch (Exception Ex)
            {

                return false;
            }
    
        }
        public bool Verifica_Reservado(Reserva Reser)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery(" SELECT ID FROM Reservas WHERE ID_Cancha = " + Reser.Cancha.ID + " AND ID_Actividad = " + Reser.Actividad.ID + " AND FECHA = convert(DATETIME, '" + Reser.Fecha + "', 103) AND HORA_DESDE = '" + Reser.HoraDesde + "' AND HORA_HASTA = '" + Reser.HoraHasta + "' AND ID_Estado_Reserva = 1 ");
                Datos.EjecutarLector();

                if(Datos.Lector.Read())
                {
                    return true;
                }

                return false;
            }
            catch (Exception Ex)
            {

                throw;
            }
        }

        //public bool Reservar(Reserva Res)
        //{
        //    try
        //    {
        //        AccesoDatos Datos = new AccesoDatos();
        //        Datos.SetearQuery("INSERT INTO RESERVAS VALUES ("+Res.Centro.ID+","+Res.Actividad.ID+","+Res.Horario.ID+","+Res.Usuario.IDUsuario+","+Res.Estado.ID+")");
        //        Datos.Ejecucion_Accion();

        //        return true;
        //    }
        //    catch (Exception Ex)
        //    {
        //        throw Ex;
        //    }
        //}
        //public List<Reserva> Listar_X_Usuario(Usuario User)
        //{
        //    List<Reserva> Lista = new List<Reserva>();
        //    AccesoDatos Datos = new AccesoDatos();
        //    Reserva Aux;

        //    try
        //    {
        //        Datos.SetearQuery("SELECT A.[ID],B.NOMBRE,C.Nombre,D.HORA_DESDE,D.HORA_HASTA,D.DURACIONJUEGO,F.DESCRIPCION FROM [TP_MATCHPOINT].[dbo].[Reservas] AS A JOIN Centros_Deportes AS B ON A.ID_Centro_Deporte = B.ID JOIN Actividades AS C ON A.ID_Actividad = C.ID JOIN HORARIOS AS D ON A.ID_Horario = D.ID JOIN Usuarios AS E ON A.ID_Usuario = E.ID JOIN Estado_Reserva AS F ON A.ID_Estado_Reserva = F.ID WHERE ID_Usuario = " + User.IDUsuario);
        //        Datos.EjecutarLector();

        //        while(Datos.Lector.Read())
        //        {
        //            Aux = new Reserva();
        //            Aux.ID = Datos.Lector.GetInt32(0);
        //            Aux.Centro = new CentroDeporte();
        //            Aux.Centro.Nombre = Datos.Lector.GetString(1);
        //            Aux.Actividad = new Actividad();
        //            Aux.Actividad.Nombre = Datos.Lector.GetString(2);
        //            Aux.Horario = new HorarioCentro();
        //            Aux.Horario.HoraDesde = Datos.Lector.GetInt32(3);
        //            Aux.Horario.HoraHasta = Datos.Lector.GetInt32(4);
        //            Aux.Horario.DuracionJuego = Datos.Lector.GetDouble(5);
        //            Aux.Estado = new EstadoReserva();
        //            Aux.Estado.Descripcion = Datos.Lector.GetString(6);

        //            Lista.Add(Aux);
        //        }

        //        return Lista;    
        //    }
        //    catch (Exception Ex)
        //    {

        //        throw Ex;
        //    }
        //}
    }
}
