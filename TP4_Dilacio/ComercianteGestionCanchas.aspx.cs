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
    public partial class ComercianteGestionCanchas : System.Web.UI.Page
    {
        public List<Cancha> ListaCancha { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargoDDList();
            }
        }
        public void CargoDDList()
        {
            CanchaNegocio CanNeg = new CanchaNegocio();
            CentroDeporte Centro = new CentroDeporte();
            List<Actividad> ListaActividades = new List<Actividad>();
            ActividadNegocio ActNeg = new ActividadNegocio();
            HorarioCancha Horario = new HorarioCancha();
            HorarioNegocio HorNeg = new HorarioNegocio();

            Cancha Cancha = new Cancha();

            Centro = (CentroDeporte)Session["Centro_Login"];

            ListaCancha = CanNeg.Listar(Centro.ID);
            ListaActividades = ActNeg.Listar();

            ddActividades.DataSource = ListaActividades;
            ddActividades.DataBind();

            ddCanchas.DataSource = ListaCancha;
            ddCanchas.DataBind();

            Cancha = CanNeg.Buscar(ddCanchas.SelectedValue, Centro.ID);

            Horario = HorNeg.BuscarHorario(Cancha.ID);

            txbDuracion.Value = Convert.ToString(Horario.Duracion);
            txbHoraDesde.Value = Convert.ToString(Horario.HoraDesde);
            txbHoraHasta.Value = Convert.ToString(Horario.HoraHasta);


  
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cancha Can = new Cancha();
                CanchaNegocio CanNeg = new CanchaNegocio();
                ActividadNegocio ActNeg = new ActividadNegocio();
                HorarioNegocio HorNeg = new HorarioNegocio();
                HorarioCancha Horario = new HorarioCancha();

                Can.Nombre =txbNombreAgregar.Value ;
                Can.Actividad = new Actividad();
                Can.Actividad = ActNeg.BuscarActividad(ddActividades.Text);

                Can.Centro = new CentroDeporte();
                Can.Centro = (CentroDeporte)Session["Centro_Login"];

                Horario.HoraDesde = TimeSpan.Parse(txbDesdeAgregar.Value);
                Horario.HoraHasta = TimeSpan.Parse(txbHastaAgregar.Value);
                Horario.Duracion = TimeSpan.Parse(txbDuracionAgregar.Value);
                Horario.Cancha = new Cancha();
                Horario.Cancha.ID = Can.ID;

                if (CanNeg.Guardar(Can))
                {
                    if(HorNeg.Guardar(Horario))
                    {
                        CargoDDList();
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        protected void Limpio_vista()
        {
            txbDuracion.Value = "";
            txbHoraDesde.Value = "";
            txbHoraHasta.Value = "";
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Cancha Cancha = new Cancha();
            CanchaNegocio CanNeg = new CanchaNegocio();
            HorarioCancha Horario = new HorarioCancha();
            HorarioNegocio HorNeg = new HorarioNegocio();

            Cancha.Centro = new CentroDeporte();
            Cancha.Centro = (CentroDeporte)Session["Centro_Login"];

            Cancha = CanNeg.Buscar(ddCanchas.SelectedValue, Cancha.Centro.ID);

            Horario = HorNeg.BuscarHorario(Cancha.ID);

            Horario.HoraHasta = TimeSpan.Parse(txbHoraHasta.Value);
            Horario.HoraDesde = TimeSpan.Parse(txbHoraDesde.Value);
            Horario.Duracion = TimeSpan.Parse(txbDuracion.Value);

            if(HorNeg.Actualizar(Horario))
            {
                Response.Write("<script>alert('Datos Modificados Correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al actualizar');</script>");
            }

        }
        protected void Actualizo_dd()
        {
            CanchaNegocio CanNeg = new CanchaNegocio();
            CentroDeporte Centro = new CentroDeporte();
            ActividadNegocio ActNeg = new ActividadNegocio();
            HorarioCancha Horario = new HorarioCancha();
            HorarioNegocio HorNeg = new HorarioNegocio();

            Cancha Cancha = new Cancha();

            Centro = (CentroDeporte)Session["Centro_Login"];

            Cancha = CanNeg.Buscar(ddCanchas.SelectedValue, Centro.ID);

            Horario = HorNeg.BuscarHorario(Cancha.ID);

            txbDuracion.Value = Convert.ToString(Horario.Duracion);
            txbHoraDesde.Value = Convert.ToString(Horario.HoraDesde);
            txbHoraHasta.Value = Convert.ToString(Horario.HoraHasta);
        }

        protected void ddCanchas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpio_vista();
            Actualizo_dd();  
        }
    }
}