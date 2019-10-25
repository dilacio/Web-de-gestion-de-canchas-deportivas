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

