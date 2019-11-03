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
    public partial class JugadorSeleccionCentro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Carga_Datos();
            }

        }

        protected void Carga_Datos()
        {
            ProvinciaNegocio ProvNeg = new ProvinciaNegocio();
            CiudadNegocio CiuNeg = new CiudadNegocio();
            LocalidadNegocio LocNeg = new LocalidadNegocio();
            BarrioNegocio BarNeg = new BarrioNegocio();
            ActividadNegocio ActNeg = new ActividadNegocio();

            ddActividad.DataSource = ActNeg.Listar();
            ddActividad.DataBind();

            ddProvincia.DataSource = ProvNeg.Listar();
            ddProvincia.DataBind();

            ddCiudad.DataSource = CiuNeg.Listar();
            ddCiudad.DataBind();

            ddLocalidad.DataSource = LocNeg.Listar();
            ddLocalidad.DataBind();

            ddBarrio.DataSource = BarNeg.Listar();
            ddBarrio.DataBind();

        }

        protected void btnBuscar_ServerClick(object sender, EventArgs e)
        {
            List<CentroDeporte> Lista = new List<CentroDeporte>();
            CentroNegocio CenNeg = new CentroNegocio();

            Lista = CenNeg.Listar_x_Filtros(ddBarrio.SelectedValue, ddLocalidad.SelectedValue, ddCiudad.SelectedValue, ddProvincia.SelectedValue);

            gvCentros.DataSource = Lista;
            gvCentros.DataBind();
        }

        protected void btnCentro_ServerClick(object sender, EventArgs e)
        {
            if(gvCentros.SelectedValue != "")
            {
                Usuario Usuario = new Usuario();

                Session["Centro_Seleccionado"] = gvCentros.SelectedValue;
                Session["Deporte_Seleccionado"] = ddActividad.SelectedValue;
                Usuario = (Usuario)(Session["User_Home"]);
                Response.Redirect("JugadorReservaOK.aspx");
            }
            else
            {
                Response.Write("<script>alert('Debe seleccionar un centro para continuar);</script>");
            }

            
        }
    }
}