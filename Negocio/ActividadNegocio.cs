using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class ActividadNegocio
    {
        AccesoDatos Datos = new AccesoDatos();

        public bool QuitarActividadACentro(int IDActividad, int IDCentro)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("delete from Actividades_Centros where ID_Actividad = " + IDActividad + "AND ID_CENTRO = " + IDCentro );
                Datos.Ejecucion_Accion();

                return true;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public Actividad BuscoID(string Nombre)
        {
            AccesoDatos Datos = new AccesoDatos();
            Actividad Aux = new Actividad();

            Datos.SetearQuery("SELECT ID FROM ACTIVIDADES WHERE NOMBRE = '"+Nombre+"'");
            Datos.EjecutarLector();

            if(Datos.Lector.Read())
            {
                Aux.ID = Datos.Lector.GetInt32(0);
                Aux.Nombre = Nombre;
            }
            return Aux;
        }
        public bool AgregarActividadACentro(int IDActividad, int IDCentro)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("insert into Actividades_Centros values (" + IDActividad + "," + IDCentro + ")");
                Datos.Ejecucion_Accion();

                return true;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public List<Actividad> Listar()
        {

            List<Actividad> Lista = new List<Actividad>();

            Actividad Aux;

            try
            {
                Datos.SetearQuery("SELECT [ID],[NOMBRE] FROM [TP_MATCHPOINT].[dbo].[Actividades]");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Actividad();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);

                    Lista.Add(Aux);
                }

                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public Actividad BuscarActividad(string Nombre)
        {
            Datos = new AccesoDatos();
            Actividad Aux = new Actividad();
            try
            {
                Datos.SetearQuery("select id, nombre from Actividades where Nombre = '"+Nombre+"'");
                Datos.EjecutarLector();

                if(Datos.Lector.Read())
                {
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);
                }
                return Aux;

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public List<Actividad> BuscarPorCentro(string Centro)
        {
            List<Actividad> Lista = new List<Actividad>();

            try
            {
                AccesoDatos Datos = new AccesoDatos();

                Datos.SetearQuery("SELECT a.[ID],a.[Nombre] FROM [TP_MATCHPOINT].[dbo].[Actividades] as a inner join Actividades_Centros as ac on ac.id_actividad = a.ID inner join Centros_Deportes as c on c.ID = ac.ID_Centro where c.NOMBRE = '"+Centro+"'");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Actividad Aux = new Actividad();

                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);

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
