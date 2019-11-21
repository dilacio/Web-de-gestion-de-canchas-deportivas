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
            txbUser.Text = Usuario.NombreUsuario;
            txbDireccion.Text = Centro.Direccion;
            txbCentroNombre.Text = Centro.Nombre;

            Cargo_ddList();
        }

        protected void Cargo_ddList()
        {
            
            CanchaNegocio CanNeg = new CanchaNegocio();

        }

        
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
               else
                {
                    Response.Write("<script>alert('Eror al actualizar');</script>");
                    
                }

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComercianteHome.aspx");
        }
    }
}