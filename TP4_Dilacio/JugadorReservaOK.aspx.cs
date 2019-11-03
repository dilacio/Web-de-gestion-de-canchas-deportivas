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
           
            Usuario = (Usuario)(Session["User_Home"]);
            Centro_seleccionado = (string)(Session["Centro_Seleccionado"]);
            Actividad_seleccionada = (string)(Session["Deporte_Seleccionado"]);
           

            txbnombre.Text = Usuario.Nombre;
            txbCentro.Text = Centro_seleccionado;
            txbape.Text = Usuario.Apellido;
            txbemail.Text = Usuario.Mail;
            txbActividad.Text = Actividad_seleccionada;


        }
        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Usuario Usuario = new Usuario();
            Reserva Reserva = new Reserva();
            ReservaNegocio ResNeg = new ReservaNegocio();

            string Centro_seleccionado;
            string Actividad_seleccionada;

            Usuario = (Usuario)(Session["User_Home"]);
            Centro_seleccionado = (string)(Session["Centro_Seleccionado"]);
            Actividad_seleccionada = (string)(Session["Deporte_Seleccionado"]);

            CentroDeporte Centro = new CentroDeporte();
            CentroNegocio cenNeg = new CentroNegocio();
            Actividad Act = new Actividad();
            ActividadNegocio ActNeg = new ActividadNegocio();

            Act = ActNeg.BuscarActividad(Actividad_seleccionada);
            Centro = cenNeg.BuscarCentro(Centro_seleccionado);

            Reserva.Actividad = new Actividad();
            Reserva.Actividad = Act;

            Reserva.Centro = new CentroDeporte();
            Reserva.Centro = Centro;

            Reserva.Estado = new EstadoReserva();
            Reserva.Estado.ID = 1 ;

            Reserva.Horario = new HorarioCentro();
            Reserva.Horario.ID = 1;

            Reserva.Usuario = Usuario;

            if (ResNeg.Reservar(Reserva))
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