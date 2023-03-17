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
    public class Mapper_User
    {
        readonly DBAccess accesso = new DBAccess();
        readonly LanguageRepository languageRepository = new LanguageRepository();
        public User GetUsuarioByLoginnamePassword(string loginname, string password)
        {
            try
            { 
                User usuario = new User();                
                int idLanguage = 0;
                
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@loginname", loginname);
                parameters[1] = new SqlParameter("@password", password);
               
                DataTable dataTable = accesso.Read("UsuarioGetByLoginnamePassword", parameters);
                
                foreach (DataRow row in dataTable.Rows)
                {
                    usuario.Id = int.Parse(row["id"].ToString());
                    usuario.DNI = row["dni"].ToString();
                    usuario.Name = row["nombre"].ToString();
                    usuario.Lastname = row["apellido"].ToString();
                    usuario.LoginName = row["loginname"].ToString();
                    usuario.Password = row["password"].ToString();
                    usuario.Idioma = languageRepository.GetLanguage(int.Parse(row["idioma"].ToString()));
                }

                return usuario;
            }
            catch 
            {
                throw new Exception();
            }
            
        }

        public User GetUsuarioById(int id)
        {
            BE.User usuario = new User();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@id", id);

            DataTable dataTable = accesso.Read("UsuarioGetById", parametro);
            foreach (DataRow row in dataTable.Rows)
            {
                usuario.Id = int.Parse(row["id"].ToString());
                usuario.DNI = row["dni"].ToString();
                usuario.Name = row["nombre"].ToString();
                usuario.Lastname = row["apellido"].ToString();
                usuario.LoginName = row["loginname"].ToString();
                usuario.Password = row["password"].ToString();
                usuario.Idioma = languageRepository.GetLanguage(int.Parse(row["idioma"].ToString()));
                usuario.Active = (bool)row["activo"];
                usuario.Role = (int)row["rol"];

            }
            return usuario;
        }

        public int Create(User usuario)
        {
            SqlCommand cmd = new SqlCommand(accesso.GetConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UsuarioCrear";            

            SqlParameter[] parametros = new SqlParameter[7];
            parametros[0] = new SqlParameter("nombre", usuario.Name);
            parametros[1] = new SqlParameter("apellido", usuario.Lastname);
            parametros[2] = new SqlParameter("dni", usuario.DNI);
            parametros[3] = new SqlParameter("loginname", usuario.LoginName);
            parametros[4] = new SqlParameter("password", usuario.Password);
            parametros[5] = new SqlParameter("activo", usuario.Active); 
            parametros[6] = new SqlParameter("fechaCreacion", DateTime.Now.ToString());

            cmd.Parameters.AddRange(parametros);

            return accesso.WriteCommand(cmd);
        }

        public int Update(User usuario)
        {
            SqlParameter[] parametros = new SqlParameter[8];
            parametros[0] = new SqlParameter("id", usuario.Id);
            parametros[1] = new SqlParameter("dni", usuario.DNI);
            parametros[2] = new SqlParameter("nombre", usuario.Name);
            parametros[3] = new SqlParameter("apellido", usuario.Lastname);
            parametros[4] = new SqlParameter("loginname", usuario.LoginName);
            parametros[5] = new SqlParameter("password", usuario.Password);            
            parametros[6] = new SqlParameter("activo", usuario.Active);
            parametros[7] = new SqlParameter("fechaCreacion", usuario.CreationDate);
            //parametros[6] = new SqlParameter("Idioma", usuario.Idioma.Id);

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
                    Name = row["nombre"].ToString(),
                    Lastname = row["apellido"].ToString(),
                    LoginName = row["loginname"].ToString(),
                    Password = row["password"].ToString(),
                    Active = bool.Parse(row["activo"].ToString()),
                    CreationDate = DateTime.Parse(row["FechaCreacion"].ToString())                    
                };

                if (row["rol"] != DBNull.Value)
                    usuario.Role = (int)row["rol"]; 

                listaUsuarios.Add(usuario);
            }

            return listaUsuarios;
        }

        public BE.User GetByLoginName(string loginname)
        {
            BE.User usuario = new User();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@loginname", loginname);

            DataTable dataTable = accesso.Read("UsuarioGetByLoginName", parametro);
            foreach (DataRow row in dataTable.Rows)
            {
                usuario.Id = int.Parse(row["id"].ToString());
                usuario.DNI = row["dni"].ToString();
                usuario.Name = row["nombre"].ToString();
                usuario.Lastname = row["apellido"].ToString();
                usuario.LoginName = row["loginname"].ToString();
                usuario.Password = row["password"].ToString();
                usuario.Idioma = languageRepository.GetLanguage(int.Parse(row["idioma"].ToString()));

            }
            return usuario;
        }
    }
}
