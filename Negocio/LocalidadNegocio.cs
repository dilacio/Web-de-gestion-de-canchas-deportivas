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

        public List<Localidad> BuscarPorProvincia(string Provincia)
        {
            List<Localidad> Lista = new List<Localidad>();
            AccesoDatos Datos = new AccesoDatos();
            Localidad Aux = new Localidad();

            Datos.SetearQuery("SELECT L.[ID],L.[NOMBRE],L.[CP],L.[ID_CIUDAD],c.nombre FROM [TP_MATCHPOINT].[dbo].[LOCALIDADES] AS L JOIN CIUDADES AS C ON L.ID_CIUDAD = C.ID join provincias as p on p.ID = C.ID_PROVINCIA WHERE P.NOMBRE = '"+Provincia+"'");
            Datos.EjecutarLector();

            while (Datos.Lector.Read())
            {
                Aux = new Localidad();
                Aux.ID = Datos.Lector.GetInt32(0);
                Aux.Nombre = Datos.Lector.GetString(1);
                Aux.CP = Datos.Lector.GetString(2);
                Aux.Ciudad = new Ciudad();
                Aux.Ciudad.ID = Datos.Lector.GetInt32(3);
                Aux.Ciudad.Nombre = Datos.Lector.GetString(4);
                Lista.Add(Aux);
            }
            return Lista;
        }
        public List<Localidad> BuscarPorCiudad(string Ciudad)
        {
            List<Localidad> Lista = new List<Localidad>();
            AccesoDatos Datos = new AccesoDatos();
            Localidad Aux = new Localidad();

            Datos.SetearQuery("SELECT L.[ID],L.[NOMBRE],L.[CP],L.[ID_CIUDAD],c.nombre  FROM [TP_MATCHPOINT].[dbo].[LOCALIDADES] AS L  JOIN CIUDADES AS C  ON L.ID_CIUDAD = C.ID  WHERE C.NOMBRE = '"+ Ciudad + "'");
            Datos.EjecutarLector();

            while (Datos.Lector.Read())
            {
                Aux = new Localidad();
                Aux.ID = Datos.Lector.GetInt32(0);
                Aux.Nombre = Datos.Lector.GetString(1);
                Aux.CP = Datos.Lector.GetString(2);
                Aux.Ciudad = new Ciudad();
                Aux.Ciudad.ID = Datos.Lector.GetInt32(3);
                Aux.Ciudad.Nombre = Datos.Lector.GetString(4);
                Lista.Add(Aux);
            }
            return Lista;

        }
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

