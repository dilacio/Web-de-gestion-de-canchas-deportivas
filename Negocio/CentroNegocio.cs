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
        public bool Actualizar(CentroDeporte Centro)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();

                Datos.SetearQuery("UPDATE CENTROS_DEPORTES SET NOMBRE = '"+Centro.Nombre+"',DIRECCION = '"+Centro.Direccion+"' WHERE ID = "+Centro.ID);
                Datos.Ejecucion_Accion();

                return true;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public CentroDeporte BuscoID(string Nombre)
        {
            AccesoDatos Datos = new AccesoDatos();
            CentroDeporte Aux = new CentroDeporte();

            Datos.SetearQuery("SELECT ID FROM Centros_Deportes WHERE NOMBRE = '" + Nombre + "'");
            Datos.EjecutarLector();

            if (Datos.Lector.Read())
            {
                Aux.ID = Datos.Lector.GetInt32(0);
                Aux.Nombre = Nombre;
            }
            return Aux;
        }

            public List<CentroDeporte> Listar_x_Filtros(string VarBarrio, string VarLocalidad, string VarCiudad, string VarPronvincia)
        {
            Datos = new AccesoDatos();
            List<CentroDeporte> Lista = new List<CentroDeporte>();

            try
            {
                Datos.SetearQuery("select a.[ID],a.[NOMBRE],a.[ID_BARRIO],a.[Direccion] , B.NOMBRE from Centros_Deportes as a join barrios as b on a.ID_BARRIO = b.ID join LOCALIDADES as c on c.ID = b.ID_Localidad join Ciudades as d on d.ID = c.ID_CIUDAD join PROVINCIAS as e on e.ID = d.ID_PROVINCIA where b.Nombre = '" + VarBarrio + "' and c.NOMBRE = '" + VarLocalidad + "' and d.NOMBRE = '"+ VarCiudad + "' and e.NOMBRE = '"+ VarPronvincia + "' ");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    CentroDeporte Centro = new CentroDeporte();

                    Centro.ID = Datos.Lector.GetInt32(0);
                    Centro.Nombre = Datos.Lector.GetString(1);
                    Centro.Barrio = new Barrio();
                    Centro.Barrio.ID = Datos.Lector.GetInt32(2);
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

        public List<CentroDeporte> Listar_x_Barrio ( string Barrio)
        {
            Datos = new AccesoDatos();
            List<CentroDeporte> Lista = new List<CentroDeporte>();

            try
            {
                Datos.SetearQuery("SELECT C.[ID],C.[NOMBRE],C.[ID_BARRIO],C.[Direccion] FROM [TP_MATCHPOINT].[dbo].[Centros_Deportes] AS C INNER JOIN BARRIOS AS B ON C.ID_BARRIO = B.ID WHERE B.Nombre = '" + Barrio+ "'");
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
        public CentroDeporte BuscarCentro(string Nombre)
        {
            Datos = new AccesoDatos();
            CentroDeporte Aux = new CentroDeporte();
            try
            {
                Datos.SetearQuery("SELECT a.[ID],a.[NOMBRE],a.[Direccion],b.ID,b.Nombre,b.ID_Localidad FROM [TP_MATCHPOINT].[dbo].[Centros_Deportes] as a join Barrios as b on b.ID = a.ID_BARRIO where a.Nombre = '" + Nombre + "'");
                Datos.EjecutarLector();

                if (Datos.Lector.Read())
                {
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);
                    Aux.Direccion = Datos.Lector.GetString(2);
                    Aux.Barrio = new Barrio();

                    Aux.Barrio.ID = Datos.Lector.GetInt32(3);
                    Aux.Barrio.Nombre = Datos.Lector.GetString(4);
                    Aux.Barrio.Localidad = new Localidad();

                    Aux.Barrio.Localidad.ID = Datos.Lector.GetInt32(5);
                }
                return Aux;

            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }
        public CentroDeporte BuscarCentroXDueño(Usuario User)
        {
            Datos = new AccesoDatos();
            CentroDeporte Aux = new CentroDeporte();
            List<CentroDeporte> Lista = new List<CentroDeporte>();
            try
            {
                Datos.SetearQuery("SELECT C.[ID],C.[NOMBRE],C.[Direccion],c.id_barrio  FROM [TP_MATCHPOINT].[dbo].[Centros_Deportes] AS C INNER JOIN usuarios as u on u.id = c.ID_DUEÑO WHERE U.ID  = " + User.IDUsuario );
                Datos.EjecutarLector();

                if (Datos.Lector.Read())
                {
                    Aux = new CentroDeporte();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);
                    Aux.Direccion = Datos.Lector.GetString(2);
                    Aux.Barrio = new Barrio();

                    Aux.Barrio.ID = Datos.Lector.GetInt32(3);

                    Lista.Add(Aux);
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
