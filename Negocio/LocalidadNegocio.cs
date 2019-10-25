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
    }

}

