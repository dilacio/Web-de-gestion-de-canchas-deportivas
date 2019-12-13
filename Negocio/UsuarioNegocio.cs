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
        public bool ActualizoABloqueado(int IDUser, int IDCentro)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("UPDATE UsuariosBloqueados SET baja = 1 where ID_Usuario = " + IDUser + "and ID_Centro = " + IDCentro);
                Datos.Ejecucion_Accion();

                return true;
            }
            catch (Exception Ex)
            {

                return false;
            }
        }
        public bool DesBloquear_Usuario(int IDUser, int IDCentro)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("UPDATE UsuariosBloqueados SET baja = 0 where ID_Usuario = "+IDUser+ "and ID_Centro = "+IDCentro);
                Datos.Ejecucion_Accion();

                return true;
            }
            catch (Exception Ex)
            {

                return false;
            }
        }
        public bool Bloquear_Usuario(int IDUser,int IDCentro)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("insert into UsuariosBloqueados values ("+IDUser+","+IDCentro+",1)");
                Datos.Ejecucion_Accion();

                return true;
            }
            catch (Exception Ex)
            {

                return false;
            }
        }
        public List<Usuario> Usuarios_Desbloqueados (int Centro)
        {
            try
            {
                List<Usuario> Lista = new List<Usuario>();
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("select u.ID, u.Nombre,u.Apellido,u.ID_Role,u.Mail,u.Nombre_Usuario from Usuarios as U where  u.ID_Role = 1 and u.ID not in (select UB.ID_Usuario from UsuariosBloqueados as UB where ub.ID_Usuario = u.ID and UB.Baja = 1 and ub.ID_Centro =" + Centro+")");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Usuario User = new Usuario();
                    User.IDUsuario = Datos.Lector.GetInt32(0);
                    User.Nombre = Datos.Lector.GetString(1);
                    User.Apellido = Datos.Lector.GetString(2);
                    User.Role = new Role();
                    User.Role.ID = Datos.Lector.GetInt32(3);
                    User.Mail = Datos.Lector.GetString(4);
                    User.NombreUsuario = Datos.Lector.GetString(5);

                    Lista.Add(User);

                }
                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public List<Usuario> Usuarios_Bloqueados (int Centro)
        {
            try
            {
                List<Usuario> Lista = new List<Usuario>();
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("SELECT u.ID, u.Nombre,u.Apellido,u.ID_Role,u.Mail,u.Nombre_Usuario FROM USUARIOS AS U INNER JOIN UsuariosBloqueados AS UB ON UB.ID_Usuario = U.ID AND UB.ID_Centro = "+Centro+" WHERE UB.Baja = 1 ");
                Datos.EjecutarLector();

                while( Datos.Lector.Read() )
                {
                    Usuario User = new Usuario();
                    User.IDUsuario = Datos.Lector.GetInt32(0);
                    User.Nombre = Datos.Lector.GetString(1);
                    User.Apellido = Datos.Lector.GetString(2);
                    User.Role = new Role();
                    User.Role.ID = Datos.Lector.GetInt32(3);
                    User.Mail = Datos.Lector.GetString(4);
                    User.NombreUsuario = Datos.Lector.GetString(5);

                    Lista.Add(User);

                }
                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public bool valido_existe_Desbloqueado(int ID_User, int Centro)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("SELECT ID_USUARIO FROM USUARIOSBLOQUEADOS WHERE ID_USUARIO =" + ID_User + " AND ID_CENTRO =" + Centro + " AND BAJA = 0");
                Datos.EjecutarLector();

                if (Datos.Lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public bool valido_existe_bloqueado( int ID_User, int Centro)
        {
            try
            {
                AccesoDatos Datos = new AccesoDatos();
                Datos.SetearQuery("SELECT ID_USUARIO FROM USUARIOSBLOQUEADOS WHERE ID_USUARIO ="+ID_User+" AND ID_CENTRO ="+Centro+" AND BAJA = 1");
                Datos.EjecutarLector();

                if(Datos.Lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        
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
