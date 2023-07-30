using Application.BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DLL
{
    public class mapper_Especialidad
    {
        readonly DBAccess accesso = new DBAccess();

        public Especialidad GetEspecialidadlById(int id)
        {
            BE.Especialidad especialidad = new Especialidad();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@id", id);

            DataTable dataTable = accesso.Read("EspecialidadGetById", parametro);
            foreach (DataRow row in dataTable.Rows)
            {
                especialidad.Id = int.Parse(row["Id"].ToString());
                especialidad.Descripcion = row["Descripcion"].ToString();
            }
            return especialidad;
        }

        public int Create(Especialidad especialidad)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("descripcion", especialidad.Descripcion);

            return accesso.Write("EspecialidadCrear", parametros);
        }

        public int Update(Especialidad especialidad)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("Id", especialidad.Id);
            parametros[1] = new SqlParameter("descripcion", especialidad.Descripcion);

            return accesso.Write("EspecialidadModificar", parametros);
        }

        public List<Especialidad> List()
        {
            List<Especialidad> listaEspecialidades = new List<Especialidad>();
            DataTable dataTable = accesso.Read("EspecialidadListar", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Especialidad especialidad = new Especialidad
                {
                    Id = int.Parse(row["id"].ToString()),
                    Descripcion = row["descripcion"].ToString(),
                };

                listaEspecialidades.Add(especialidad);
            }

            return listaEspecialidades;
        }
    }

}
