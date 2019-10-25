using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        public SqlDataReader Lector { get; set; }
        public SqlConnection Conexion { get; }
        public SqlCommand Comando { get; set; }

        public AccesoDatos()
        {
            Conexion = new SqlConnection("data source=NBBASAR605\\SQLEXPRESS; initial catalog=TP_MATCHPOINT; integrated security=sspi");
            Comando = new SqlCommand();
            Comando.Connection = Conexion;
        }

        public void SetearQuery(string Consulta)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Consulta;
        }

        public void SetearSP(string SP)
        {

        }
        public void AgregarParametro(string Nombre, string Valor)
        {
            Comando.Parameters.AddWithValue(Nombre, Valor);

        }

        public void EjecutarLector()
        {
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                
            }

        }
        public void CerrarConexion()
        {
            Conexion.Close();
        }
        public void Ejecucion_Accion()
        {
            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.Close();
            }

        }
    }
}
