using Application.BE;
using System;
using System.Collections.Generic;
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
            if (permiso.Padre.Nombre != null)
                parametros[1] = new SqlParameter("IdPadre", permiso.Padre.Nombre);
            else
                parametros[1] = new SqlParameter("IdPadre", DBNull.Value);

            return accesso.Escribir("PermisoCrear", parametros);
        }
    }
}
