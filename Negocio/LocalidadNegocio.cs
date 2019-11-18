using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class LocalidadNegocio
    {
        AccesoDatos Datos = new AccesoDatos();
        public List<Localidad> Listar()
        {

            List<Localidad> Lista = new List<Localidad>();

            Localidad Loc;

            try
            {
                Datos.SetearQuery("SELECT [ID],[NOMBRE] FROM [TP_MATCHPOINT].[dbo].[LOCALIDADES]");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Loc = new Localidad();
                    Loc.ID = Datos.Lector.GetInt32(0);
                    Loc.Nombre = Datos.Lector.GetString(1);

                    Lista.Add(Loc);
                }

                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public List<Localidad> Listar(string Ciudad)
        {

            List<Localidad> Lista = new List<Localidad>();

            Localidad Loc;

            try
            {
                Datos.SetearQuery("SELECT l.[ID],l.[NOMBRE] FROM [TP_MATCHPOINT].[dbo].[LOCALIDADES] as l  join Ciudades as c on c.id = l.id_ciudad where c.nombre ='" +Ciudad+"'");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Loc = new Localidad();
                    Loc.ID = Datos.Lector.GetInt32(0);
                    Loc.Nombre = Datos.Lector.GetString(1);

                    Lista.Add(Loc);
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

