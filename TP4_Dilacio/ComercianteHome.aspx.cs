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
    public partial class ComercianteHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CentroNegocio CenNeg = new CentroNegocio();
            CentroDeporte Centro = new CentroDeporte();

            Usuario Usuario = new Usuario();
            Usuario = (Usuario)(Session["User_Home"]);

            Centro = CenNeg.BuscarCentroXDueño(Usuario);
            Session["Centro_Login"] = Centro;
        }
        protected void btn_ABM_datos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComercianteABMDatos.aspx");
        }
        protected void btnIrReserva_click_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComercianteVerReservas.aspx");
        }

        protected void btnGestionCanchas_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComercianteGestionCanchas.aspx");
        }
    }
}