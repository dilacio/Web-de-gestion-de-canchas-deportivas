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
    public partial class JugadorReseraOK : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario Usuario = new Usuario();
            string Centro_seleccionado;
            string Actividad_seleccionada;
            Reserva Reserva = new Reserva();

            Reserva = (Reserva)Session["Reserva_Final"];
           
            Usuario = (Usuario)(Session["User_Home"]);
            Centro_seleccionado = (string)(Session["Centro_Seleccionado"]);
            Actividad_seleccionada = (string)(Session["Deporte_Seleccionado"]);
           
  
            txbnombre.Text = Reserva.Usuario.Nombre;
            txbCentro.Text = Centro_seleccionado;
            txbape.Text = Reserva.Usuario.Apellido;
            txbemail.Text = Reserva.Usuario.Mail;
            txbActividad.Text = Reserva.Actividad.Nombre;
            txbFechaJuego.Value = Reserva.Fecha.ToString("dd/MM/yyyy");
            TxbDesde.Text = Reserva.HoraDesde.ToString();
            txbHasta.Value = Reserva.HoraHasta.ToString();
            

        }
        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Reserva Reserva = new Reserva();
            ReservaNegocio ResNeg = new ReservaNegocio();

            Reserva = (Reserva)Session["Reserva_Final"];
            
            if(ResNeg.Guardar(Reserva))
            {
                Response.Redirect("JugadorFinalizar.aspx");
            }
            else
            {
                Response.Redirect("JugadorReservaFallida.aspx");
            }

        }

       
    }
}