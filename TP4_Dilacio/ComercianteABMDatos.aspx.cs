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
    public partial class ComercianteABMDatos : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Carga_Datos_txb();
                Cargo_ddList();
            }
        }
        void Carga_Datos_txb()
        {
            Usuario Usuario = new Usuario();
            Usuario = (Usuario)(Session["User_Home"]);
            CentroNegocio CenNeg = new CentroNegocio();
            CentroDeporte Centro = new CentroDeporte();

            Centro = CenNeg.BuscarCentroXDueño(Usuario);
       
            txbnombre.Text = Usuario.Nombre;
            txbMail.Text = Usuario.Mail;
            txbape.Text = Usuario.Apellido;
            txbDireccion.Text = Centro.Direccion;
            txbCentroNombre.Text = Centro.Nombre;

            Cargo_ddList();
        }

        protected void Cargo_ddList()
        {
            
            CanchaNegocio CanNeg = new CanchaNegocio();



            //

            //if(ListaCancha.Count() > 0)
            //{
            //    ddActGestion.DataSource = ListaCancha;
            //    ddActGestion.DataBind();
            //}
            //else
            //{
            //    ddActGestion.Text = "No tenés canchas";

            //}
        

            //Lista_ActPorCentro = ActNeg.BuscarPorCentro(Centro.Nombre);
            //ListaActTodas = ActNeg.Listar();

            //List<Actividad> ListaAgregarAct = new List<Actividad>();
            //ddactividades.DataSource = Lista_ActPorCentro;
            //ddactividades.DataBind();

            //for (int i=0;i<ListaActTodas.Count();i++)
            //{
            //    int Cont = 0;
            //    for (int e=0;e<Lista_ActPorCentro.Count();e++)
            //    {
            //        if (Lista_ActPorCentro[e].Nombre == ListaActTodas[i].Nombre)
            //        {
            //            Cont++;
            //        }  
            //    }
            //    if(Cont==0)
            //    {
            //        ListaAgregarAct.Add(ListaActTodas[i]);
            //    }
            //}
            //ddNuevaActividad.DataSource = ListaAgregarAct;
            //ddNuevaActividad.DataBind();
        }

        //protected void btnAgregarActividad_Click(object sender, EventArgs e)
        //{
        //    Actividad Act = new Actividad();
        //    ActividadNegocio ActNeg = new ActividadNegocio();

        //    CentroDeporte Centro = new CentroDeporte();
        //    CentroNegocio CenNeg = new CentroNegocio();

            

        //    try
        //    {
        //        Act = ActNeg.BuscoID(ddNuevaActividad.SelectedValue);
        //        Centro = CenNeg.BuscoID(txbCentroNombre.Text);
        //        ActNeg.AgregarActividadACentro(Act.ID, Centro.ID);

        //        Cargo_ddList();
        //    }
        //    catch (Exception Ex)
        //    {

        //        throw Ex;
        //    }
        //}

        //protected void btnQuitarActividad_Click(object sender, EventArgs e)
        //{
        //    Actividad Act = new Actividad();
        //    ActividadNegocio ActNeg = new ActividadNegocio();

        //    CentroDeporte Centro = new CentroDeporte();
        //    CentroNegocio CenNeg = new CentroNegocio();

        //    try
        //    {
        //        Act = ActNeg.BuscoID(ddactividades.SelectedValue);
        //        Centro = CenNeg.BuscoID(txbCentroNombre.Text);
        //        ActNeg.QuitarActividadACentro(Act.ID, Centro.ID);

        //        Cargo_ddList();
        //    }
        //    catch (Exception Ex)
        //    {

        //        throw Ex;
        //    }
        //}

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            CentroDeporte Centro_Nuevo = new CentroDeporte();
            CentroDeporte Centro = new CentroDeporte();
            CentroNegocio CenNeg = new CentroNegocio();

            Centro = (CentroDeporte)(Session["Centro_Login"]);

            try
            {
                Centro_Nuevo.ID = Centro.ID ;
                Centro_Nuevo.Nombre = txbCentroNombre.Text;
                Centro_Nuevo.Direccion = txbDireccion.Text;

               if(CenNeg.Actualizar(Centro_Nuevo))
                {
                    Response.Write("<script>alert('Datos Actualizados correctamente);</script>");
                }

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}