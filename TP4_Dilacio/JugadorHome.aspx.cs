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
            ProvinciaNegocio ProvNeg= new ProvinciaNegocio();
            CiudadNegocio CiuNeg = new CiudadNegocio();
            LocalidadNegocio LocNeg = new LocalidadNegocio();
            BarrioNegocio BarNeg = new BarrioNegocio();
            CentroNegocio CenNeg = new CentroNegocio();

            List<CentroDeporte> Lista = new List<CentroDeporte>();

            ddProvincia.DataSource = ProvNeg.Listar();
            ddProvincia.DataBind();

            ddCiudad.DataSource = CiuNeg.Listar();
            ddCiudad.DataBind();

            ddLocalidad.DataSource = LocNeg.Listar();
            ddLocalidad.DataBind();

            ddBarrio.DataSource = BarNeg.Listar();
            ddBarrio.DataBind();

            Lista = CenNeg.Listar_x_Barrio(ddBarrio.SelectedValue);

            gvCentros.DataSource = CenNeg.Listar_x_Barrio(ddBarrio.SelectedValue);
            gvCentros.DataBind();




        }
    }
}