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
    }
}
