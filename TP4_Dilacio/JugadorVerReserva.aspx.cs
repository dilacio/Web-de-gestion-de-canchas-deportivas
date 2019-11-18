﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;


namespace TP4_Dilacio
{
    public partial class JugadorVerReserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Carga_datos();

        }
        void Carga_datos()
        {
            ReservaNegocio ResNeg = new ReservaNegocio();
            List<Reserva> Lista = new List<Reserva>();
            Usuario Usuario = new Usuario();

            Usuario = (Usuario)Session["User_Home"];

            Lista = ResNeg.ListarPorUsuario(Usuario);


            gvReservasHechas.DataSource = Lista;
            gvReservasHechas.DataBind();
        }
        protected void gvReservasHechas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ReservaNegocio ResNeg = new ReservaNegocio();

            int IDReserva;

            IDReserva = Convert.ToInt32(gvReservasHechas.Rows[e.RowIndex].Cells[1].Text);

            if(ResNeg.BajaReserva(IDReserva))
            {

                Response.Write("<script>alert('Reserva dada de baja correctamente');</script>");
                Carga_datos();


            }
        }
    }
}