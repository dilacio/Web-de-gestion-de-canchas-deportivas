using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Dilacio
{
    public partial class JugadorFinalizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Response.Redirect("JugadorHome.aspx");
        }
    }
}