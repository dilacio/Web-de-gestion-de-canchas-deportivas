using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Dilacio
{
    public partial class ComercianteHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ABM_datos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComercianteABMDatos.aspx");
        }

        protected void btnIrReserva_click_Click(object sender, EventArgs e)
        {

        }
    }
}