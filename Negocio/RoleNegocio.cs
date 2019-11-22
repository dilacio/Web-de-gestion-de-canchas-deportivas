using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class RoleNegocio
    {
        AccesoDatos Datos = new AccesoDatos();

        public List<Role> Listar()
        {

            List<Role> Lista = new List<Role>();

            Role Role;

            try
            {
                Datos.SetearQuery("SELECT [ID],[DESCRIPCION] FROM [ROLES]");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Role = new Role();
                    Role.ID = Datos.Lector.GetInt32(0);
                    Role.Descripcion = Datos.Lector.GetString(1);

                    Lista.Add(Role);
                }

                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public Role Buscar(string Valor)
        {
            Role Obj;


            try
            {
                Datos.SetearQuery("SELECT [ID],[DESCRIPCION] FROM [ROLES] WHERE [DESCRIPCION]= '" + Valor + "'");
                Datos.EjecutarLector();

                if (Datos.Lector.Read())
                {
                    Obj = new Role();
                    Obj.ID = Datos.Lector.GetInt32(0);
                    Obj.Descripcion = Datos.Lector.GetString(1);
                    return Obj;
                }
                Obj = null;

                return Obj;
            }

            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}