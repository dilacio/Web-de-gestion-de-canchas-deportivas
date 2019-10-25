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

