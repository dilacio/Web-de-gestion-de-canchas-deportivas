using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CanchaNegocio
    {
        public List<Cancha> Listar(int Centro)
        {
            AccesoDatos Datos = new AccesoDatos();

            List<Cancha> Lista = new List<Cancha>();

            Cancha Aux;

            try
            {
                Datos.SetearQuery("SELECT  A.[ID],A.[ID_Centro],A.[nombre],A.[ID_Actividad] FROM [TP_MATCHPOINT].[dbo].[CANCHAS] AS A INNER JOIN Centros_Deportes AS C ON A.ID_CENTRO = C.ID WHERE ID_CENTRO ="+Centro);
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Cancha();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Centro = new CentroDeporte();
                    Aux.Centro.ID = Datos.Lector.GetInt32(1);
                    Aux.Nombre = Datos.Lector.GetString(2);
                    Aux.Actividad = new Actividad();
                    Aux.Actividad.ID = Datos.Lector.GetInt32(3); 

                    Lista.Add(Aux);
                }

                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public List<Cancha> ListarPorDeporte(int Centro,string Deporte)
        {
            AccesoDatos Datos = new AccesoDatos();

            List<Cancha> Lista = new List<Cancha>();

            Cancha Aux;

            try
            {
                Datos.SetearQuery("SELECT  A.[ID],A.[ID_Centro],A.[nombre],A.[ID_Actividad] FROM [TP_MATCHPOINT].[dbo].[CANCHAS] AS A INNER JOIN Centros_Deportes AS C ON A.ID_CENTRO = C.ID join Actividades as act on act.ID = a.ID_Actividad WHERE ID_CENTRO ="+Centro+ "and act.Nombre = '" +Deporte+"'");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Cancha();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Centro = new CentroDeporte();
                    Aux.Centro.ID = Datos.Lector.GetInt32(1);
                    Aux.Nombre = Datos.Lector.GetString(2);
                    Aux.Actividad = new Actividad();
                    Aux.Actividad.ID = Datos.Lector.GetInt32(3);

                    Lista.Add(Aux);
                }

                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public bool Guardar(Cancha Cancha)
        {
             try
             {
                 AccesoDatos Datos = new AccesoDatos();
                 Datos.SetearQuery("INSERT INTO CANCHAS VALUES (" + Cancha.Centro.ID + ",'" + Cancha.Nombre + "'," + Cancha.Actividad.ID +")");
                 Datos.Ejecucion_Accion();

                 return true;
             }
             catch (Exception Ex)
             {
                 throw Ex;
             }
        }
        public Cancha Buscar(string NombreCancha,int IDCentro)
        {
            try
            {
                Cancha Aux = new Cancha();
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("SELECT [ID],[ID_Centro],[nombre],[ID_Actividad] FROM [dbo].[CANCHAS] where nombre = '"+NombreCancha+"' and id_centro =" + IDCentro);
                Datos.EjecutarLector();

                if(Datos.Lector.Read())
                {
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Centro = new CentroDeporte();
                    Aux.Centro.ID = Datos.Lector.GetInt32(1);
                    Aux.Nombre = Datos.Lector.GetString(2);
                    Aux.Actividad = new Actividad();
                    Aux.Actividad.ID = Datos.Lector.GetInt32(3);
                }
                return Aux;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
