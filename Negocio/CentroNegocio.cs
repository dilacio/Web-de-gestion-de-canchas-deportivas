using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    
    public class CentroNegocio
    {
        AccesoDatos Datos;
        
        public List<CentroDeporte> Listar_x_Barrio ( string Barrio)
        {
            Datos = new AccesoDatos();
            List<CentroDeporte> Lista = new List<CentroDeporte>();

            try
            {
                Datos.SetearQuery("SELECT C.[ID],C.[NOMBRE],C.[ID_BARRIO],C.[Direccion], B.NOMBRE FROM [TP_MATCHPOINT].[dbo].[Centros_Deportes] AS C INNER JOIN BARRIOS AS B ON C.ID_BARRIO = B.ID WHERE B.Nombre = '" + Barrio+ "'");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    CentroDeporte Centro = new CentroDeporte();

                    Centro.ID = Datos.Lector.GetInt32(0);
                    Centro.Nombre =  Datos.Lector.GetString(1);
                    Centro.Barrio = new Barrio();
                    Centro.Barrio.ID =  Datos.Lector.GetInt32(2);
                    Centro.Direccion = Datos.Lector.GetString(3);
                    Centro.Barrio.Nombre = Datos.Lector.GetString(4);

                    Lista.Add(Centro);

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
