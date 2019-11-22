using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class HorarioNegocio
    {
        public HorarioCancha BuscarHorario(int Cancha)
        {
            HorarioCancha Aux = new HorarioCancha();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("SELECT [ID],[ID_CANCHA],[HORA_DESDE],[HORA_HASTA],[DURACIONJUEGO] FROM [HORARIOS] WHERE ID_CANCHA ="+ Cancha);
                Datos.EjecutarLector();

                if (Datos.Lector.Read())
                {
                    Aux.Cancha = new Cancha();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Cancha.ID = Datos.Lector.GetInt32(1);
                    Aux.HoraDesde = Datos.Lector.GetTimeSpan(2);
                    Aux.HoraHasta = Datos.Lector.GetTimeSpan(3);
                    Aux.Duracion = Datos.Lector.GetTimeSpan(4);
                }

                return Aux;
            }
            catch (Exception Ex)
            {
                
                throw Ex;
            }
        }
        public bool Guardar(HorarioCancha Horario)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("INSERT INTO HORARIOS VALUES (" + Horario.Cancha.ID + ",'" + Horario.HoraDesde +"','"+Horario.HoraHasta+"','" +Horario.Duracion+"')");
                Datos.Ejecucion_Accion();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Actualizar (HorarioCancha Horario)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos() ;
                Datos.SetearQuery("update horarios set [HORA_DESDE] = '"+Horario.HoraDesde + "', [HORA_HASTA] = '" +Horario.HoraHasta+ "' , [DURACIONJUEGO] = '" + Horario.Duracion+ "' where id = "+ Horario.ID);
                Datos.EjecutarLector();

                return true;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
