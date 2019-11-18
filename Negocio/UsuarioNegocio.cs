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
        
        public Usuario Busca_Usuario(string User)
        {
            AccesoDatos Datos = new AccesoDatos();
            UsuarioNegocio UsuNeg = new UsuarioNegocio();

            try
            {
                Datos.SetearQuery("SELECT a.[ID],a.[Nombre],a.[ID_Role],r.DESCRIPCION , a.[Mail], a.apellido FROM [dbo].[Usuarios] as a inner join [dbo].[ROLES] as r on a.ID_Role = r.ID where a.[Nombre] = '" + User +"'" );
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
                Datos.SetearQuery("SELECT a.[ID],a.[Nombre],a.[ID_Role],r.DESCRIPCION , a.[Mail],a.Apellido FROM [dbo].[Usuarios] as a inner join [dbo].[ROLES] as r on a.ID_Role = r.ID where a.[Nombre] = '" + User + "' and a.[Password] = '" + Pass + "'");

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
                Datos.SetearQuery("insert into Usuarios values (@Nombre,@Pass,@IDRole,@Mail,@Apellido)");
                Datos.AgregarParametro("@Nombre", Us.Nombre.ToString());
                Datos.AgregarParametro("@Pass", Us.Password.ToString());
                Datos.AgregarParametro("@IDRole", Us.Role.ID.ToString());
                Datos.AgregarParametro("@Mail", Us.Mail.ToString());
                Datos.AgregarParametro("@Apellido", Us.Apellido.ToString());

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
