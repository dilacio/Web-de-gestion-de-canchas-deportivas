using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public int BuscoID(string Nombre,string Apellido)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("SELECT ID FROM USUARIOS WHERE NOMBRE = '" + Nombre + "' and APELLIDO = '"+Apellido+"'");
                Datos.EjecutarLector();

                if(Datos.Lector.Read())
                {
                    return Datos.Lector.GetInt32(0);
                }

                return 0;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public Usuario Busca_Usuario(string Nombre,string Apellido)
        {
            AccesoDatos Datos = new AccesoDatos();
            UsuarioNegocio UsuNeg = new UsuarioNegocio();

            try
            {
                Datos.SetearQuery("SELECT a.[ID],a.[Nombre],a.[ID_Role],r.DESCRIPCION , a.[Mail], a.apellido,a.Nombre_Usuario FROM [Usuarios] as a inner join [dbo].[ROLES] as r on a.ID_Role = r.ID WHERE NOMBRE = '" + Nombre + "' and APELLIDO = '" + Apellido + "'");
                Datos.EjecutarLector();

                Usuario Us;

                while (Datos.Lector.Read())
                {
                    Us = new Usuario();
                    Us.IDUsuario = Datos.Lector.GetInt32(0);
                    Us.Nombre = Datos.Lector.GetString(1);
                    Us.Role = new Role();
                    Us.Role.ID = Datos.Lector.GetInt32(2);
                    Us.Role.Descripcion = Datos.Lector.GetString(3);
                    Us.Mail = Datos.Lector.GetString(4);
                    Us.Apellido = Datos.Lector.GetString(5);
                    Us.NombreUsuario = Datos.Lector.GetString(6);

                    return Us;
                }
                Us = null;
                return Us;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public Usuario Valida_Credenciales(string User, string Pass)
        {
            AccesoDatos Datos = new AccesoDatos();
            UsuarioNegocio UsuNeg = new UsuarioNegocio();

            try
            {
                Datos.SetearQuery("SELECT a.[ID],a.[Nombre],a.[ID_Role],r.DESCRIPCION , a.[Mail],a.Apellido,a.Nombre_Usuario FROM [Usuarios] as a inner join [ROLES] as r on a.ID_Role = r.ID where a.[Nombre_Usuario] = '" + User + "' and a.[Password] = '" + Pass + "'");

                Datos.EjecutarLector();
                Usuario Us;

                while (Datos.Lector.Read())
                {
                    Us = new Usuario();
                    Us.IDUsuario = Datos.Lector.GetInt32(0);
                    Us.Nombre = Datos.Lector.GetString(1);
                    Us.Role = new Role();
                    Us.Role.ID = Datos.Lector.GetInt32(2);
                    Us.Role.Descripcion = Datos.Lector.GetString(3);
                    Us.Mail = Datos.Lector.GetString(4);
                    Us.Apellido = Datos.Lector.GetString(5);
                    Us.NombreUsuario = Datos.Lector.GetString(6);

                    return Us;
                }
                Us = null;
                return Us;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public bool Guardar(Usuario Us)
        {
            bool Resultado = false;
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("insert into Usuarios values (@Nombre,@Nombre_Usuario,@Pass,@IDRole,@Mail,@Apellido)");
                Datos.AgregarParametro("@Nombre", Us.Nombre.ToString());
                Datos.AgregarParametro("@Pass", Us.Password.ToString());
                Datos.AgregarParametro("@IDRole", Us.Role.ID.ToString());
                Datos.AgregarParametro("@Mail", Us.Mail.ToString());
                Datos.AgregarParametro("@Apellido", Us.Apellido.ToString());
                Datos.AgregarParametro("@Nombre_Usuario",Us.NombreUsuario.ToString());

                Datos.Ejecucion_Accion();

                Resultado = true;
                return Resultado;
  
                
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
