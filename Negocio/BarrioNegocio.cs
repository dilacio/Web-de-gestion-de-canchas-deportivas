using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class BarrioNegocio
    {
        AccesoDatos Datos = new AccesoDatos();

        public List<Barrio> BuscarPorProvincia(string Provincia)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Barrio Aux;
                List<Barrio> Lista = new List<Barrio>();
                Datos.SetearQuery("SELECT B.ID, b.Nombre ,b.ID_Localidad FROM BARRIOS AS B JOIN LOCALIDADES AS L ON L.ID = B.ID_LOCALIDAD JOIN CIUDADES AS C ON C.ID = L.ID_CIUDAD JOIN PROVINCIAS AS P ON P.ID = C.ID_PROVINCIA WHERE P.NOMBRE = '"+Provincia+"'");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Barrio();

                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);
                    Aux.Localidad = new Localidad();
                    Aux.Localidad.ID = Datos.Lector.GetInt32(2);

                    Lista.Add(Aux);
                }
                return Lista;

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public List<Barrio> BuscarPorCiudad(string Ciudad)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Barrio Aux;
                List<Barrio> Lista = new List<Barrio>();
                Datos.SetearQuery("SELECT B.ID, b.Nombre ,b.ID_Localidad FROM BARRIOS AS B JOIN LOCALIDADES AS L ON L.ID = B.ID_LOCALIDAD JOIN CIUDADES AS C ON C.ID = L.ID_CIUDAD WHERE C.NOMBRE = '"+Ciudad+"'");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Barrio();

                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);
                    Aux.Localidad = new Localidad();
                    Aux.Localidad.ID = Datos.Lector.GetInt32(2);

                    Lista.Add(Aux);
                }
                return Lista;

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public List<Barrio> BuscarPorLocalidad(string Localidad)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Barrio Aux;
                List<Barrio> Lista = new List<Barrio>();
                Datos.SetearQuery("SELECT B.ID, b.Nombre ,b.ID_Localidad FROM BARRIOS AS B JOIN LOCALIDADES AS L ON L.ID = B.ID_LOCALIDAD  WHERE L.NOMBRE = '"+Localidad+"'");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Barrio();

                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);
                    Aux.Localidad = new Localidad();
                    Aux.Localidad.ID = Datos.Lector.GetInt32(2);

                    Lista.Add(Aux);
                }
                return Lista;

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public List<Barrio> Listar()
        {

            List<Barrio> Lista = new List<Barrio>();

            Barrio Aux;

            try
            {
                Datos.SetearQuery("SELECT [ID],[NOMBRE] FROM [TP_MATCHPOINT].[dbo].[BARRIOS]");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Barrio();
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

