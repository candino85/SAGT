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
    public class Mapper_Usuario
    {
        readonly DBAccess accesso = new DBAccess();
        readonly mapper_Language mapper_Language = new mapper_Language();
        public User GetUsuarioByLoginnamePassword(string loginname, string password)
        {
            User usuario = new User();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@loginname", loginname);
            parameters[1] = new SqlParameter("@password", password);
            DataTable dataTable = accesso.Read("UsuarioGetByLoginnamePassword", parameters);
            foreach (DataRow row in dataTable.Rows)
            {
                usuario.Id = int.Parse(row["id"].ToString());
                usuario.DNI = row["dni"].ToString();
                usuario.Nombre = row["nombre"].ToString();
                usuario.Apellido = row["apellido"].ToString();
                usuario.LoginName = row["loginname"].ToString();
                usuario.Password = row["password"].ToString();
                usuario.Idioma = mapper_Language.GetLanguage(int.Parse(row["idioma"].ToString()));
            }
            return usuario;
        }

        public User GetUsuarioById(int id)
        {
            BE.User usuario = new User();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@id", id);

            DataTable dataTable = accesso.Read("UsuarioGetById", parametro);
            foreach (DataRow row in dataTable.Rows)
            {
                usuario.Id = int.Parse(row["Id"].ToString());
                usuario.Nombre = row["Name"].ToString();
                usuario.LoginName = row["Loginname"].ToString();
                usuario.Password = row["Password"].ToString();
                usuario.Idioma = mapper_Language.GetLanguage(row["Idioma"].ToString());
                //usuario.Guid = row["Guid"];
            }
            return usuario;
        }

        public int Create(User usuario)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("Nombre",usuario.Nombre);
            parametros[1] = new SqlParameter("Apellido",usuario.Apellido);
            parametros[2] = new SqlParameter("DNI",usuario.DNI);
            parametros[3] = new SqlParameter("Loginname",usuario.LoginName);
            parametros[4] = new SqlParameter("Password",usuario.Password);
            //parametros[6] = new SqlParameter("Idioma", usuario.Idioma.Id); 
            //parametros[7] = new SqlParameter("Guid", usuario.Guid);

            return accesso.Write("UsuarioCrear", parametros);
        }

        public int Update(User usuario)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("Id", usuario.Id); 
            parametros[1] = new SqlParameter("DNI", usuario.DNI);
            parametros[2] = new SqlParameter("Nombre", usuario.Nombre); 
            parametros[3] = new SqlParameter("Apellido", usuario.Apellido); 
            parametros[4] = new SqlParameter("Loginname", usuario.LoginName); 
            parametros[5] = new SqlParameter("Password", usuario.Password);
            //parametros[6] = new SqlParameter("Idioma", usuario.Idioma.Id);
            //parametros[7] = new SqlParameter("Guid", usuario.Guid); 

            return accesso.Write("UsuarioModificar", parametros);
        }

        public int Remove(int id)
        {
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("Id", id);
            
            return accesso.Write("UsuarioEliminar", parametro);
        }

        public List<User> List()
        {
            List<User> listaUsuarios = new List<User>();
            DataTable dataTable = accesso.Read("UsuarioListar", null);

            foreach (DataRow row in dataTable.Rows)
            {
                User usuario = new User
                {
                    Id = int.Parse(row["id"].ToString()),
                    DNI = row["dni"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Apellido = row["apellido"].ToString(),
                    LoginName = row["loginname"].ToString(),
                    Password = row["password"].ToString()
                };

                listaUsuarios.Add(usuario);
            }

            return listaUsuarios;
        }
    }
}
