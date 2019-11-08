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
    public partial class JugadorHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btnIrReserva_click(object sender, EventArgs e)
        {
            Response.Redirect("JugadorVerReserva.aspx");
        }
        protected void btnIrComenzarReserva_click(object sender, EventArgs e)
        {
            Response.Redirect("JugadorSeleccionCentro.aspx");
        }
    }
 
}