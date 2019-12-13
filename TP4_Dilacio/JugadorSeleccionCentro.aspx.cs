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

            ddCiudad.DataSource = CiuNeg.BuscarPorProvincia(ddProvincia.SelectedValue);
            ddCiudad.DataBind();

            ddLocalidad.DataSource = LocNeg.Listar(ddCiudad.SelectedValue);
            ddLocalidad.DataBind();

            ddBarrio.DataSource = BarNeg.Listar();
            ddBarrio.DataBind();
        }

        protected void btnBuscar_ServerClick(object sender, EventArgs e)
        {
            List<CentroDeporte> Lista = new List<CentroDeporte>();
            CentroNegocio CenNeg = new CentroNegocio();

            Lista = CenNeg.Listar_x_Filtros(ddBarrio.SelectedValue, ddLocalidad.SelectedValue, ddCiudad.SelectedValue, ddProvincia.SelectedValue,ddActividad.SelectedValue);

            gvCentros.DataSource = Lista;
            gvCentros.DataBind();
        }

        protected void btnCentro_ServerClick(object sender, EventArgs e)
        {
            if(gvCentros.SelectedValue != "")
            {
                UsuarioNegocio UserNeg = new UsuarioNegocio();
                Usuario Usuario = new Usuario();
                CentroDeporte Centro = new CentroDeporte();
                CentroNegocio CenNeg = new CentroNegocio();

                Session["Centro_Seleccionado"] = gvCentros.SelectedValue;
                Session["Deporte_Seleccionado"] = ddActividad.SelectedValue;
                Usuario = (Usuario)(Session["User_Home"]);

                Centro = CenNeg.BuscarCentro((string)Session["Centro_Seleccionado"]);

                if (!UserNeg.valido_existe_bloqueado(Usuario.IDUsuario,Centro.ID))
                {
                    Response.Redirect("JugadorReservaSeleccion.aspx");
                }
                else
                {
                    Response.Write("<script>alert('El centro que intenta seleccionar no permite que reserves en su centro por mal comportamiento en las reservas, por favor contactarse con el centro');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Debe seleccionar un centro para continuar);</script>");
            }            
        }

        protected void ddProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CiudadNegocio CiuNeg = new CiudadNegocio();
            LocalidadNegocio LocNeg = new LocalidadNegocio();
            BarrioNegocio BarNeg = new BarrioNegocio();

            ddCiudad.Items.Clear();
            ddCiudad.DataSource = CiuNeg.BuscarPorProvincia(ddProvincia.SelectedValue);
            ddCiudad.DataBind();

            ddLocalidad.Items.Clear();
            ddLocalidad.DataSource = LocNeg.BuscarPorProvincia(ddProvincia.SelectedValue);
            ddLocalidad.DataBind();

            ddBarrio.Items.Clear();
            ddBarrio.DataSource = BarNeg.BuscarPorProvincia(ddProvincia.SelectedValue);
            ddBarrio.DataBind();
        }
        protected void ddCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadNegocio LocNeg = new LocalidadNegocio();
            BarrioNegocio BarNeg = new BarrioNegocio();

            ddLocalidad.Items.Clear();
            ddLocalidad.DataSource = LocNeg.BuscarPorCiudad(ddCiudad.SelectedValue);
            ddLocalidad.DataBind();

            ddBarrio.Items.Clear();
            ddBarrio.DataSource = BarNeg.BuscarPorCiudad(ddCiudad.SelectedValue);
            ddBarrio.DataBind();
        }

        protected void ddLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            BarrioNegocio BarNeg = new BarrioNegocio();

            ddBarrio.Items.Clear();
            ddBarrio.DataSource = BarNeg.BuscarPorLocalidad(ddLocalidad.SelectedValue);
            ddBarrio.DataBind();
        }
    }
}