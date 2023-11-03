using Application.BE;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Application.DLL
{
    public class Mapper_Sucursal
    {
        readonly DBAccess accesso = new DBAccess();
        //readonly mapper_Language mapper_Language = new mapper_Language();
        //public User GetUsuarioByLoginnamePassword(string loginname, string password)
        //{
        //    User usuario = new User();
        //    SqlParameter[] parameters = new SqlParameter[2];
        //    parameters[0] = new SqlParameter("@loginname", loginname);
        //    parameters[1] = new SqlParameter("@password", password);
        //    DataTable dataTable = accesso.Read("UsuarioGetByLoginnamePassword", parameters);
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        usuario.Id = int.Parse(row["id"].ToString());
        //        usuario.DNI = row["dni"].ToString();
        //        usuario.Nombre = row["nombre"].ToString();
        //        usuario.Apellido = row["apellido"].ToString();
        //        usuario.LoginName = row["loginname"].ToString();
        //        usuario.Password = row["password"].ToString();
        //        usuario.Idioma = mapper_Language.GetLanguage(int.Parse(row["idioma"].ToString()));
        //    }
        //    return usuario;
        //}

        public Sucursal GetlById(int id)
        {
            BE.Sucursal sucursal = new Sucursal();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@id", id);

            DataTable dataTable = accesso.Read("EntidadGetById", parametro);
            foreach (DataRow row in dataTable.Rows)
            {
                sucursal.Id = int.Parse(row["Id"].ToString());
                sucursal.Name = row["Nombre"].ToString();
                sucursal.Address = row["Direccion"].ToString();
                sucursal.Phone = row["Telefono"].ToString();
                sucursal.Cuit = row["Cuit"].ToString();
                sucursal.Active = bool.Parse(row["Activo"].ToString());
            }
            return sucursal;
        }

        public int Create(Sucursal sucursal)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("Nombre", sucursal.Name);
            parametros[1] = new SqlParameter("Direccion", sucursal.Address);
            parametros[2] = new SqlParameter("Telefono", sucursal.Phone);
            parametros[3] = new SqlParameter("Cuit", sucursal.Cuit);
            parametros[4] = new SqlParameter("Activo", sucursal.Active);
            //parametros[6] = new SqlParameter("Idioma", usuario.Idioma.Id); 
            //parametros[7] = new SqlParameter("Guid", usuario.Guid);

            return accesso.Write("EntidadCrear", parametros);
        }

        public int Update(Sucursal sucursal)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("Id", sucursal.Id);
            parametros[1] = new SqlParameter("Cuit", sucursal.Cuit);
            parametros[2] = new SqlParameter("Nombre", sucursal.Name);
            parametros[3] = new SqlParameter("Direccion", sucursal.Address);
            parametros[4] = new SqlParameter("Telefono", sucursal.Phone);
            parametros[5] = new SqlParameter("Activo", sucursal.Active);
            //parametros[6] = new SqlParameter("Idioma", usuario.Idioma.Id);
            //parametros[7] = new SqlParameter("Guid", usuario.Guid); 

            return accesso.Write("EntidadModificar", parametros);
        }

        //public int Remove(int id)
        //{
        //    SqlParameter[] parametro = new SqlParameter[1];
        //    parametro[0] = new SqlParameter("Id", id);

        //    return accesso.Write("UsuarioEliminar", parametro);
        //}

        public List<Sucursal> List()
        {
            List<Sucursal> listaSucursales = new List<Sucursal>();
            DataTable dataTable = accesso.Read("EntidadListar", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Sucursal sucursal = new Sucursal
                {
                    Id = int.Parse(row["id"].ToString()),
                    Name = row["nombre"].ToString(),
                    Address = row["direccion"].ToString(),
                    Phone = row["telefono"].ToString(),
                    Cuit = row["cuit"].ToString(),
                    Active = bool.Parse(row["activo"].ToString())
                };

                listaSucursales.Add(sucursal);
            }

            return listaSucursales;
        }
    }
}
