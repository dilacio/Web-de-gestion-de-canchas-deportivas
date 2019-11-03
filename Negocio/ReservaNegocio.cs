using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class ReservaNegocio
    {
        AccesoDatos Datos;

        public bool Reservar(Reserva Res)
        {
           

            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("INSERT INTO RESERVAS VALUES ("+Res.Centro.ID+","+Res.Actividad.ID+","+Res.Horario.ID+","+Res.Usuario.IDUsuario+","+Res.Estado.ID+")");
                Datos.Ejecucion_Accion();

                return true;
            }
            catch (Exception Ex)
            {
                
                throw Ex;
            }
        }
    }
}
