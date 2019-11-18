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
    public partial class JugadorReservaSeleccion : System.Web.UI.Page
    {
        string fecha;
        protected void Page_Load(object sender, EventArgs e)
        {
            string Cen,Deporte;
            CentroDeporte Centro = new CentroDeporte();
            CentroNegocio CenNeg = new CentroNegocio();
            List<Cancha> Cancha = new List<Cancha>();
            CanchaNegocio CanNeg = new CanchaNegocio();

            Cen = (string)Session["Centro_Seleccionado"];
            Deporte = (string)Session["Deporte_Seleccionado"];
            Centro = CenNeg.BuscarCentro(Cen);

            Cancha = CanNeg.ListarPorDeporte(Centro.ID,Deporte);

            Session["Cancha_Seleccionada"] = ddCanchas.SelectedValue;
            ddCanchas.DataSource = Cancha;
            ddCanchas.DataBind();

            
        }
        

        [System.Web.Services.WebMethod()]
        //public static int GetAjax( string date)
        //{
            
        //    int Dia=0, Mes=0, Anio=0;
        //    int Cont = 0;
        //    int Date;
            
        //    //"November 19 2019"
        //    string[] separatingStrings = { " " };

        //    string text = date;
            
        //    string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
           
        //    foreach (var word in words)
        //    {
        //       if(Cont==0)
        //        {
        //            if (word == "January")
        //            {
        //                Mes = 1;
        //            }
        //            if (word == "February")
        //            {
        //                Mes = 2;
        //            }
        //            if (word == "March")
        //            {
        //                Mes = 3;
        //            }
        //            if (word == "April")
        //            {
        //                Mes = 4;
        //            }
        //            if (word == "May")
        //            {
        //                Mes = 5;
        //            }
        //            if (word == "June")
        //            {
        //                Mes = 6;
        //            }
        //            if (word == "July")
        //            {
        //                Mes = 7;
        //            }
        //            if (word == "August")
        //            {
        //                Mes = 8;
        //            }
        //            if (word == "September")
        //            {
        //                Mes = 9;
        //            }
        //            if (word == "October")
        //            {
        //                Mes = 10;
        //            }
        //            if (word == "November")
        //            {
        //                Mes = 11;
        //            }
        //            if (word == "December")
        //            {
        //                Mes = 12;
        //            }
        //        }
        //       if (Cont == 1)
        //        {
        //            Dia = Convert.ToInt32(word);
        //        }
        //       if(Cont == 2)
        //        {
        //            Anio = Convert.ToInt32(word);
                    
        //        }
        //        Cont++;
        //    }
        //    Date = Convert.ToInt32( string.Concat(Dia ,Mes, Anio));

        //    return Date;
        //}


        protected void txbfecha_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnAdelante_Click(object sender, EventArgs e)
        {
            List<HorarioCancha> Lista = new List<HorarioCancha>();
            HorarioNegocio HorNeg = new HorarioNegocio();
            HorarioCancha Horario = new HorarioCancha();
            HorarioCancha Aux = new HorarioCancha();
            Cancha Cancha = new Cancha();
            CanchaNegocio CanNeg = new CanchaNegocio();
            CentroDeporte Centro = new CentroDeporte();
            CentroNegocio CenNeg = new CentroNegocio();
            Reserva Reserva = new Reserva();
            ReservaNegocio ResNeg = new ReservaNegocio();
            Actividad Actividad = new Actividad();
            ActividadNegocio ActNeg = new ActividadNegocio();

            TimeSpan Aux_Desde, Aux_Hasta;
            string Cen;
            List<TimeSpan> Lista_Horarios = new List<TimeSpan>(); ;

            int Dia = 0, Mes = 0, Anio = 0;
            int Cont = 0;
            DateTime Date;
            //"November 19 2019"
            string[] separatingStrings = { " " };

            string text = txbfecha.Text;

            string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (Cont == 0)
                {
                    if (word == "January")
                    {
                        Mes = 1;
                    }
                    if (word == "February")
                    {
                        Mes = 2;
                    }
                    if (word == "March")
                    {
                        Mes = 3;
                    }
                    if (word == "April")
                    {
                        Mes = 4;
                    }
                    if (word == "May")
                    {
                        Mes = 5;
                    }
                    if (word == "June")
                    {
                        Mes = 6;
                    }
                    if (word == "July")
                    {
                        Mes = 7;
                    }
                    if (word == "August")
                    {
                        Mes = 8;
                    }
                    if (word == "September")
                    {
                        Mes = 9;
                    }
                    if (word == "October")
                    {
                        Mes = 10;
                    }
                    if (word == "November")
                    {
                        Mes = 11;
                    }
                    if (word == "December")
                    {
                        Mes = 12;
                    }
                }
                if (Cont == 1)
                {
                    Dia = Convert.ToInt32(word);
                }
                if (Cont == 2)
                {
                    Anio = Convert.ToInt32(word);

                }
                Cont++;
            }
            Date = new DateTime(Anio, Mes,Dia);

            Session["Fecha_Seleccionado"] = Date;

            Cen = (string)Session["Centro_Seleccionado"];
            Centro = CenNeg.BuscarCentro(Cen);

            Cancha = CanNeg.Buscar(ddCanchas.SelectedValue, Centro.ID);
            Horario = HorNeg.BuscarHorario(Cancha.ID);
            Aux_Desde = Horario.HoraDesde;
            Aux_Hasta = Horario.HoraHasta;

           while (Aux_Desde <= Aux_Hasta)
            {
                Aux = new HorarioCancha();
                Aux.HoraDesde = Aux_Desde;
                 
                Lista_Horarios.Add(Aux_Desde);
                Aux_Desde = Aux_Desde + Horario.Duracion;
                Aux.HoraHasta = Aux_Desde;
                Aux.Duracion = Horario.Duracion;

                Reserva.Actividad = new Actividad();
                Actividad.Nombre = (string)Session["Deporte_seleccionado"] ;

                Reserva.Actividad = ActNeg.BuscarActividad(Actividad.Nombre);
                Reserva.Cancha = new Cancha();
                Reserva.Cancha = Cancha;
                Reserva.Fecha = Date;
                Reserva.HoraDesde = Aux.HoraDesde;
                Reserva.HoraHasta = Aux.HoraHasta;

                if(!ResNeg.Verifica_Reservado(Reserva))
                {
                    Lista.Add(Aux);
                }

            }
            lbHorarios_Disponibles.DataSource = Lista;
            lbHorarios_Disponibles.DataBind();
            Session["Pre_Reserva"] = Reserva ;
                
        }
        protected void BuscarHorarios(DateTime Fecha)
        {
            
        }

        protected void lbHorarios_Disponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reserva Reserva = new Reserva();
            string Hora_desde, Hora_Hasta;
            Usuario User = new Usuario();

            Reserva = (Reserva)Session["Pre_Reserva"];
            User = (Usuario)Session["User_Home"];

            Hora_desde = lbHorarios_Disponibles.SelectedRow.Cells[2].Text;
            Hora_Hasta = lbHorarios_Disponibles.SelectedRow.Cells[3].Text;
            Reserva.HoraDesde = TimeSpan.Parse(Hora_desde);
            Reserva.HoraHasta = TimeSpan.Parse(Hora_Hasta);
            Reserva.Estado = new EstadoReserva();
            Reserva.Estado.ID = 1;
            Reserva.Usuario = new Usuario();
            Reserva.Usuario = User;

            Session["Reserva_Final"] = Reserva;

            Response.Redirect("JugadorReservaOK.aspx");
        }
    }
}