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
    public partial class ComercianteAltaCentro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BarrioNegocio BarNeg = new BarrioNegocio();

                ddBarrio.DataSource = BarNeg.Listar();
                ddBarrio.DataBind();
            }
        }

        protected void btnLogin_ServerClick(object sender, EventArgs e)
        {
            Barrio Barrio = new Barrio();
            BarrioNegocio BarNeg = new BarrioNegocio();
            Usuario User = new Usuario();
            CentroDeporte Centro = new CentroDeporte();
            CentroNegocio CenNeg = new CentroNegocio();

            User = (Usuario)Session["User_Home"];
            Centro.Direccion = txbDireccion.Value;
            Centro.Nombre = txbNombre.Value;

            Centro.Barrio = new Barrio();
            Centro.Barrio.Nombre = ddBarrio.SelectedValue;

            Barrio = BarNeg.BuscarPorNombre(ddBarrio.SelectedValue);

            Centro.Barrio = Barrio;
            Centro.Dueño = new Usuario();
            Centro.Dueño = User;

            if(CenNeg.Guardar(Centro))
            {
                Response.Write("<script>alert('Centro dado de alta correctamente');</script>");
                Response.Redirect("ComercianteHome.aspx");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al dar de alta, por favor verifique');</script>");
                Response.Redirect("ComercianteHome.aspx");
            }


        }
    }
}