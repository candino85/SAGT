using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BE;
using System.Data.SqlClient;
using System.Data;
using Application.Services;

namespace Application.DLL
{
    public class Mapper_Area
    {
        readonly DBAccess accesso = new DBAccess();
        readonly LanguageRepository languageRepository = new LanguageRepository();
        readonly Mapper_Entity entity = new Mapper_Entity();
        public Area GetAreaById(int id)
        {
            try
            {
                BE.Area area = new Area();
                SqlParameter[] parametro = new SqlParameter[1];
                parametro[0] = new SqlParameter("@id", id);

                DataTable dataTable = accesso.Read("EspacioGetById", parametro);
                foreach (DataRow row in dataTable.Rows)
                {
                    area.Id = (int)dataTable.Rows[0]["id"];
                    area.Name = dataTable.Rows[0]["nombre"].ToString();
                    area.Description = dataTable.Rows[0]["descripcion"].ToString();
                    area.Entity = entity.GetEntityById((int)dataTable.Rows[0]["entidad"]);
                    area.Active = (bool)dataTable.Rows[0]["activo"];
                }
                return area;
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

        public BE.Area GetAreaByName(Area area)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("nombre", area.Name);
                parametros[1] = new SqlParameter("entidad", area.Entity.Id);

                DataTable dataTable = accesso.Read("EspacioGetByName", parametros);

                if (dataTable.Rows.Count == 1)
                {
                    area.Id = (int)dataTable.Rows[0]["id"];
                    area.Name = dataTable.Rows[0]["nombre"].ToString();
                    area.Description = dataTable.Rows[0]["descripcion"].ToString();
                    area.Entity = entity.GetEntityById((int)dataTable.Rows[0]["entidad"]);
                    area.Active = (bool)dataTable.Rows[0]["activo"];
                }

                return area;
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }

        }

        public int Create(Area area)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(accesso.GetConnectionString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EspacioCrear";

                SqlParameter[] parametros = new SqlParameter[4];
                parametros[0] = new SqlParameter("nombre", area.Name);
                parametros[1] = new SqlParameter("descripcion", area.Description);
                parametros[2] = new SqlParameter("entidad", area.Entity.Id);
                parametros[3] = new SqlParameter("activo", area.Active);


                cmd.Parameters.AddRange(parametros);

                return accesso.WriteCommand(cmd);
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

        public int Update(Area area)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[5];
                parametros[0] = new SqlParameter("id", area.Id);
                parametros[1] = new SqlParameter("nombre", area.Name);
                parametros[2] = new SqlParameter("descripcion", area.Description);
                parametros[3] = new SqlParameter("entidad", area.Entity.Id);
                parametros[4] = new SqlParameter("activo", area.Active);

                return accesso.Write("EspacioModificar", parametros);
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

        public int Remove(int id)
        {
            try
            {
                SqlParameter[] parametro = new SqlParameter[1];
                parametro[0] = new SqlParameter("id", id);

                return accesso.Write("EspacioEliminar", parametro);
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }

        }

        public List<Area> List()
        {
            try
            {
                List<Area> listaEspacios = new List<Area>();
                DataTable dataTable = accesso.Read("EspacioListar", null);

                foreach (DataRow row in dataTable.Rows)
                {
                    Area area = new Area
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Name = row["nombre"].ToString(),
                        Description = row["descripcion"].ToString(),
                        Entity = entity.GetEntityById((int)row["entidad"]),
                        Active = (bool)row["activo"]
                    };
                    listaEspacios.Add(area);
                }
                return listaEspacios;
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

    }
}
