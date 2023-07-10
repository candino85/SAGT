using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BE;
using System.Data.SqlClient;
using System.Data;

namespace Application.DLL
{
    public class Mapper_Estudio
    {
        readonly DBAccess accesso = new DBAccess();

        public Estudio GetById(int id)
        {
            BE.Estudio estudio = new Estudio();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@id", id);

            DataTable dataTable = accesso.Read("EstudioGetById", parametro);
            foreach (DataRow row in dataTable.Rows)
            {
                estudio.Id = int.Parse(row["Id"].ToString());
                estudio.Nombre = row["Nombre"].ToString();
                estudio.Especialidad = int.Parse(row["especialidad"].ToString());
                estudio.Tiempo = int.Parse(row["tiempo"].ToString());
                estudio.Activo = bool.Parse(row["activo"].ToString());
            }
            return estudio;
        }

        public int Create(Estudio estudio)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("nombre", estudio.Nombre);
            parametros[1] = new SqlParameter("especialidad",estudio.Especialidad);
            parametros[2] = new SqlParameter("tiempo",estudio.Tiempo);
            parametros[3] = new SqlParameter("activo", estudio.Activo);


            return accesso.Write("EstudioCrear", parametros);
        }

        public int Update(Estudio estudio)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", estudio.Id);
            parametros[1] = new SqlParameter("nombre", estudio.Nombre);
            parametros[2] = new SqlParameter("especialidad", estudio.Especialidad);
            parametros[3] = new SqlParameter("tiempo", estudio.Tiempo);
            parametros[4] = new SqlParameter("activo", estudio.Activo);

            return accesso.Write("EstudioModificar", parametros);
        }

        //public int Remove(int id)
        //{
        //    SqlParameter[] parametro = new SqlParameter[1];
        //    parametro[0] = new SqlParameter("Id", id);
            
        //    return accesso.Write("UsuarioEliminar", parametro);
        //}

        public List<Estudio> List()
        {
            List<Estudio> estudios = new List<Estudio>();
            DataTable dataTable = accesso.Read("EstudioListar", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Estudio estudio = new Estudio
                {
                    Id = int.Parse(row["id"].ToString()),
                    Nombre = row["nombre"].ToString(),
                    Especialidad = int.Parse(row["especialidad"].ToString()),
                    Tiempo = int.Parse(row["tiempo"].ToString()),
                    Activo = bool.Parse(row["activo"].ToString())
                };

                estudios.Add(estudio);
            }

            return estudios;
        }
    }
}
