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
    public partial class JugadorAvisaNoIR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_ServerClick(object sender, EventArgs e)
        {
            ReservaNegocio ResNeg = new ReservaNegocio();
            int IDReserva;
            IDReserva = (int)Session["ReservaACancelar"] ;

            if(ResNeg.LiberarReserva(IDReserva))
            {
                Response.Write("<script>alert('Muchas gracias por avisar, ya se liberó la reserva ');</script>");
                Response.Redirect("JugadorVerReserva.aspx");
            }
            
        }

        protected void VoyAIr_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("JugadorVerReserva.aspx");
        }
    }
}