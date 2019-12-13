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
    public partial class ComercianteVerCancelaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Cargo_Datos();
            }
        }

        protected void Cargo_Datos()
        {
            ReservaNegocio ResNeg = new ReservaNegocio();
            List<Reserva> Lista = new List<Reserva>();
            UsuarioNegocio UserNeg = new UsuarioNegocio();
            CentroDeporte Centro;

            Lista = ResNeg.Res_canceladasPorUser(); ;

            gvReservasCanceladas.DataSource = Lista;
            gvReservasCanceladas.DataBind();
            Centro = (CentroDeporte)Session["Centro_Login"];

            gvBloqueados.DataSource = UserNeg.Usuarios_Bloqueados(Centro.ID);
            gvBloqueados.DataBind();

            gvDesbloqueados.DataSource = UserNeg.Usuarios_Desbloqueados(Centro.ID);
            gvDesbloqueados.DataBind();
        }

        protected void gvReservasCanceladas_SelectedIndexChanged(object sender, EventArgs e)
        {
            

       
        }

        protected void btnBloquear_Click(object sender, EventArgs e)
        {
            UsuarioNegocio UserNeg = new UsuarioNegocio();
            CentroDeporte Centro;
            Usuario User = new Usuario();
           
            Centro = (CentroDeporte)Session["Centro_Login"];

            User.IDUsuario = int.Parse(gvDesbloqueados.SelectedValue);

            if(UserNeg.valido_existe_Desbloqueado(User.IDUsuario,Centro.ID))
            {
                if(UserNeg.ActualizoABloqueado(User.IDUsuario,Centro.ID))
                {
                    Cargo_Datos();
                }
            }
            else
            {

                if (UserNeg.Bloquear_Usuario(User.IDUsuario, Centro.ID))
                {
                    Cargo_Datos();
                }
            }
        }

        protected void btnDesBloquear_Click(object sender, EventArgs e)
        {
            UsuarioNegocio UserNeg = new UsuarioNegocio();
            CentroDeporte Centro;
            Usuario User = new Usuario();

            Centro = (CentroDeporte)Session["Centro_Login"];

            User.IDUsuario = int.Parse(gvBloqueados.SelectedValue);

            if (UserNeg.valido_existe_bloqueado(User.IDUsuario, Centro.ID))
            {
                if (UserNeg.DesBloquear_Usuario(User.IDUsuario, Centro.ID))
                {
                    Cargo_Datos();
                }
            }
        }
    }
}