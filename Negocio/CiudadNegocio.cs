using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CiudadNegocio
    {
        AccesoDatos Datos = new AccesoDatos();

        public List<Ciudad> BuscarPorProvincia(string Provincia)
        {
            List<Ciudad> Lista = new List<Ciudad>();
            AccesoDatos Datos = new AccesoDatos();
            Ciudad Aux = new Ciudad();

            Datos.SetearQuery("SELECT c.ID,c.NOMBRE FROM CIUDADES AS C JOIN PROVINCIAS AS P ON P.ID = C.ID_PROVINCIA WHERE p.NOMBRE = '"+Provincia+"'");
            Datos.EjecutarLector();

            while(Datos.Lector.Read())
            {
                Aux = new Ciudad();
                Aux.ID = Datos.Lector.GetInt32(0);
                Aux.Nombre = Datos.Lector.GetString(1);
       
                Lista.Add(Aux);
            }
            return Lista;
            
        }
        public List<Ciudad> Listar()
        {

            List<Ciudad> Lista = new List<Ciudad>();

            Ciudad Aux;

            try
            {
                Datos.SetearQuery("SELECT [ID],[NOMBRE] FROM [TP_MATCHPOINT].[dbo].[CIUDADES]");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Ciudad();
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

