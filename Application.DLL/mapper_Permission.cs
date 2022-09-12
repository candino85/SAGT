using Application.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DLL
{
    public class Mapper_Permission
    {
        readonly DBAccess accesso = new DBAccess();

        public int Crear(Permission permiso)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("Nombre", permiso.Nombre);
            parametros[1] = new SqlParameter("IdPadre", DBNull.Value);

            return accesso.Write("PermisoCrear", parametros);
        }
        public int Editar(Permission permiso)
        {
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("Id", permiso.Id);
            parametros[1] = new SqlParameter("Nombre", permiso.Nombre);
            parametros[2] = new SqlParameter("IdPadre", DBNull.Value);

            return accesso.Write("PermisoEditar", parametros);
        }
        public List<Permission> Listar()
        {
            List<Permission> listaPermisos = new List<Permission>();
            DataTable dataTable = accesso.Read("PermisosListar", null);
            Role role = new Role(null, null);
            foreach (DataRow row in dataTable.Rows)
            {
                
                var Id = int.Parse(row["id"].ToString());
                var Nombre = row["nombre"].ToString();
                var Padre = role;
                Permission permisos = new Permission(Id, Nombre, Padre);

                listaPermisos.Add(permisos);
            }

            return listaPermisos;
        }
    }
}
