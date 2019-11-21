using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP4_Dilacio
{
    public partial class CrearCuenta : System.Web.UI.Page
    {
        public List<Role> Lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Lista = new List<Role>();
                RoleNegocio RolNegocio = new RoleNegocio();

                Lista = RolNegocio.Listar();

                ddRole.DataSource = Lista;
                ddRole.DataBind();
            }
         }

        protected void btnLogin_ServerClick(object sender, EventArgs e)
        {
            UsuarioNegocio UsNeg = new UsuarioNegocio();
            Usuario usuario = new Usuario();
            RoleNegocio RolNeg = new RoleNegocio();

            usuario = UsNeg.Busca_Usuario(txbNombre.Value,txbApellido.Value);
            

            if (usuario == null  )
            {
                usuario = new Usuario();

                usuario.Nombre = txbNombre.Value;
                usuario.NombreUsuario = txbUser.Value;
                usuario.Apellido = txbApellido.Value;
                usuario.Mail = txbMail.Value;
                usuario.Password = txbPass.Value;
                usuario.Role = new Role();

                usuario.Role = RolNeg.Buscar(ddRole.SelectedValue);

                if(UsNeg.Guardar(usuario))
                {
                    if(usuario.Role.Descripcion == "Jugador")
                    {
                        usuario.IDUsuario = UsNeg.BuscoID(usuario.Nombre, usuario.Apellido);
                        Session["User_Home"] = usuario;
                        Response.Write("<script>alert('Usuario dado de alta correctamente, por favor inicie sesion');</script>");
                        Response.Redirect("JugadorHome.aspx");
                    }
                    else
                    {
                        usuario.IDUsuario = UsNeg.BuscoID(usuario.Nombre, usuario.Apellido);
                        Session["User_Home"] = usuario;
                        Response.Write("<script>alert('Usuario dado de alta correctamente, por favor ahora de de alta su centro');</script>");
                        Response.Redirect("ComercianteAltaCentro.aspx");
                    }
                    
                }
            }
            else
            {
                Response.Write("<script>alert('El usuario ya existe');</script>");
            }
        }
    }
}