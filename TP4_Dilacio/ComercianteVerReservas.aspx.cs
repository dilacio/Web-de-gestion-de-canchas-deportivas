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
    public partial class ComercianteVerReservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Carga_datos();
        }
        void Carga_datos()
        {
            ReservaNegocio ResNeg = new ReservaNegocio();
            List<Reserva> Lista = new List<Reserva>();
            Usuario Usuario = new Usuario();
            CentroDeporte Centro = new CentroDeporte();
            CentroNegocio CenNeg = new CentroNegocio();

            Usuario = (Usuario)Session["User_Home"];
            Centro = CenNeg.BuscarCentroXDueño(Usuario);

            Lista = ResNeg.ListarPorCentro(Centro);


            gvReservasHechas.DataSource = Lista;
            gvReservasHechas.DataBind();
        }
    }
}