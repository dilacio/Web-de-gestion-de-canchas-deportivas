using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class ProvinciaNegocio
    {
        AccesoDatos Datos = new AccesoDatos();
        public List<Provincia> Listar()
        {
           
            List<Provincia> Lista = new List<Provincia>();

            Provincia Prov;

            try
            {
                Datos.SetearQuery("SELECT [ID],[NOMBRE] FROM [PROVINCIAS]");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Prov = new Provincia();
                    Prov.ID = Datos.Lector.GetInt32(0);
                    Prov.Nombre = Datos.Lector.GetString(1);

                    Lista.Add(Prov);
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
