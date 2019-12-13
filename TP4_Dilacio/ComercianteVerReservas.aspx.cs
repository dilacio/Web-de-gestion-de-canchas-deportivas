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
        bool ckbx = true;
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

            Lista = ResNeg.ListarPorCentro_TodosEstados(Centro);


            gvReservasHechas.DataSource = Lista;
            gvReservasHechas.DataBind();

            gvReservasAsistidas.DataSource = ResNeg.ListarPorCentro_Asistidos(Centro);
            gvReservasAsistidas.DataBind();
        }

        protected void gvReservasHechas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ReservaNegocio ResNeg = new ReservaNegocio();


            //int index = Convert.ToInt32(e.CommandArgument);

            //int id = Convert.ToInt32(gvReservasHechas.Rows[index].Cells[1]);

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gvReservasHechas.Rows[index];
            int id = Convert.ToInt32(row.Cells[1].Text);

            if(ResNeg.update_Asistio(id))
            {
                Carga_datos();
            }

        }
    }
}