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
           Lista = new List<Role>();
            RoleNegocio RolNegocio = new RoleNegocio();

            Lista = RolNegocio.Listar();

            ddRole.DataSource = Lista;
            ddRole.DataBind();

        }

        protected void btnLogin_ServerClick(object sender, EventArgs e)
        {
            UsuarioNegocio UsNeg = new UsuarioNegocio();
            Usuario usuario = new Usuario();
            RoleNegocio RolNeg = new RoleNegocio();

            usuario = UsNeg.Busca_Usuario(txbUser.Value);
            

            if (usuario == null  )
            {
                usuario = new Usuario();

                usuario.Nombre = txbUser.Value;
                usuario.Mail = txbMail.Value;
                usuario.Password = txbPass.Value;
                usuario.Role = new Role();
                
                usuario.Role = RolNeg.Buscar(ddRole.SelectedValue);

                if(UsNeg.Guardar(usuario))
                {
                    Response.Write("<script>alert('Usuario dado de alta correctamente, por favor inicie sesion');</script>");

                    Response.Redirect("HomeView.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('El usuario ya existe');</script>");
            }
        }
    }
}