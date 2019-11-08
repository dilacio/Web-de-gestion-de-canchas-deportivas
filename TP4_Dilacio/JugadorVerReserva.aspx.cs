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
    public partial class JugadorVerReserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReservaNegocio ResNeg = new ReservaNegocio();
            Usuario User = new Usuario();
            List<Reserva> Lista = new List<Reserva>();

            User = (Usuario)(Session["User_Home"]);

            Lista = ResNeg.Listar_X_Usuario(User);

            gvReservas.DataSource = Lista;
            gvReservas.DataBind();

        }
    }
}