using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BE;
using System.Data.SqlClient;
using System.Data;
using Application.Services;
using System.Security.Policy;

namespace Application.DLL
{
    public class Mapper_User
    {
        readonly DBAccess accesso = new DBAccess();
        readonly LanguageRepository languageRepository = new LanguageRepository();
        readonly Mapper_Entity entity = new Mapper_Entity();

        //public User GetUsuarioByLoginnamePassword(string loginname, string password)
        //{
        //    try
        //    { 
        //        User usuario = new User();
                
        //        SqlParameter[] parameters = new SqlParameter[2];
        //        parameters[0] = new SqlParameter("@loginname", loginname);
        //        parameters[1] = new SqlParameter("@password", password);
               
        //        DataTable dataTable = accesso.Read("UsuarioGetByLoginnamePassword", parameters);
                
        //        foreach (DataRow row in dataTable.Rows)
        //        {
        //            usuario.Id = int.Parse(row["id"].ToString());
        //            usuario.DNI = row["dni"].ToString();
        //            usuario.Name = row["nombre"].ToString();
        //            usuario.Lastname = row["apellido"].ToString();
        //            usuario.LoginName = row["loginname"].ToString();
        //            usuario.Password = row["password"].ToString();
        //            usuario.Language = languageRepository.GetLanguage((int)row["idioma"]);
        //            usuario.Address = row["direccion"].ToString();
        //            usuario.Active = (bool)row["activo"];
        //            usuario.Entity = (entity.GetEntityById((int)row["Entidad"]));
        //            usuario.Role = row["role"] != DBNull.Value ? (int)row["role"] : 0;
        //            usuario.Email = row["email"].ToString();
        //            usuario.Blocked = (bool)row["bloqueado"];
        //            usuario.CreationDate = (DateTime)row["fechacreacion"];
        //        }

        //        return usuario;
        //    }
        //    catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        //}

        public User GetUsuarioById(int id)
        {
            try
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
                    usuario.Language = languageRepository.GetLanguage(int.Parse(row["idioma"].ToString()));
                    usuario.Active = (bool)row["activo"];
                    usuario.Role = (int)row["rol"];
                    usuario.Entity = entity.GetEntityById((int)row["Entidad"]);
                    usuario.Address = row["direccion"].ToString();
                    usuario.Email = row["email"].ToString();
                    usuario.Blocked = (bool)row["bloqueado"];
                    usuario.CreationDate = (DateTime)row["fechacreacion"];
                    usuario.Attempts = (int)row["intentos"];
                }
                return usuario;
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

        public int Create(User usuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(accesso.GetConnectionString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UsuarioCrear";

                SqlParameter[] parametros = new SqlParameter[14];
                parametros[0] = new SqlParameter("nombre", usuario.Name);
                parametros[1] = new SqlParameter("apellido", usuario.Lastname);
                parametros[2] = new SqlParameter("dni", usuario.DNI);
                parametros[3] = new SqlParameter("loginname", usuario.LoginName);
                parametros[4] = new SqlParameter("password", usuario.Password);
                parametros[5] = new SqlParameter("activo", usuario.Active);
                parametros[6] = new SqlParameter("fechaCreacion", DateTime.Now.ToString());
                parametros[7] = new SqlParameter("direccion", usuario.Address);
                parametros[8] = new SqlParameter("idioma", usuario.Language.Id);
                parametros[9] = new SqlParameter("role", usuario.Role);
                parametros[10] = new SqlParameter("entidad", usuario.Entity.Id);
                parametros[11] = new SqlParameter("email", usuario.Email);
                parametros[12] = new SqlParameter("bloqueado", usuario.Blocked);
                parametros[13] = new SqlParameter("intentos", 0);

                cmd.Parameters.AddRange(parametros);

                return accesso.WriteCommand(cmd);
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

        public int Update(User usuario)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[13];
                parametros[0] = new SqlParameter("id", usuario.Id);
                parametros[1] = new SqlParameter("dni", usuario.DNI);
                parametros[2] = new SqlParameter("nombre", usuario.Name);
                parametros[3] = new SqlParameter("apellido", usuario.Lastname);
                parametros[4] = new SqlParameter("loginname", usuario.LoginName);
                parametros[5] = new SqlParameter("password", usuario.Password);
                parametros[6] = new SqlParameter("activo", usuario.Active);
                parametros[7] = new SqlParameter("idioma", usuario.Language.Id);
                parametros[8] = new SqlParameter("role", usuario.Role);
                parametros[9] = new SqlParameter("entidad", usuario.Entity.Id);
                parametros[10] = new SqlParameter("email", usuario.Email);
                parametros[11] = new SqlParameter("bloqueado", usuario.Blocked);
                parametros[12] = new SqlParameter("intentos", usuario.Attempts);

                return accesso.Write("UsuarioModificar", parametros);
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

        public int Remove(int id)
        {
            try
            {
                SqlParameter[] parametro = new SqlParameter[1];
                parametro[0] = new SqlParameter("Id", id);

                return accesso.Write("UsuarioEliminar", parametro);
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

        public List<User> List()
        {
            try
            {
                List<User> listaUsuarios = new List<User>();
                DataTable dataTable = accesso.Read("UsuarioListar", null);

                foreach (DataRow row in dataTable.Rows)
                {
                    User usuario = new User
                    {
                        Id = (int)row["id"],
                        DNI = row["dni"].ToString(),
                        Name = row["nombre"].ToString(),
                        Lastname = row["apellido"].ToString(),
                        LoginName = row["loginname"].ToString(),
                        Password = row["password"].ToString(),
                        Active = (bool)row["activo"],
                        CreationDate = (DateTime)row["FechaCreacion"],
                        Entity = entity.GetEntityById((int)row["Entidad"]),
                        Language = languageRepository.GetLanguage((int)row["idioma"]),
                        Role = row["role"] != DBNull.Value ? (int)row["role"] : 0,
                        //Address = row["direccion"] != DBNull.Value ? row["direccion"].ToString() : string.Empty
                        Address = row["direccion"].ToString(),
                        Email = row["email"].ToString(),
                        Blocked = (bool)row["bloqueado"],
                        Attempts = (int)row["intentos"]
                    };

                    listaUsuarios.Add(usuario);
                }

                return listaUsuarios;
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

        public BE.User GetByLoginName(string loginname)
        {
            try
            {
                BE.User usuario = new User();
                //usuario.LoginName = loginname;
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
                    usuario.Language = languageRepository.GetLanguage(int.Parse(row["idioma"].ToString()));
                    usuario.Active = (bool)row["activo"];
                    usuario.Role = (int)row["role"];
                    usuario.Entity = entity.GetEntityById((int)row["Entidad"]);
                    usuario.Address = row["direccion"].ToString();
                    usuario.Email = row["email"].ToString();
                    usuario.Blocked = (bool)row["bloqueado"];
                    usuario.Attempts = (int)row["intentos"];

                }
                return usuario;
            }
            catch (Exception ex) { throw new DataAccessException("Sucedió un error en DAL", ex); }
        }

        public int UpdatePassword(string username, string password) 
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("loginname", username);
                parametros[1] = new SqlParameter("password", password);
                return accesso.Write("Update_Password", parametros);
            }
            catch (Exception ex) 
            {
                throw new DataAccessException("Sucedió un error en DAL",ex);
            }
             
        }

        public void FailLoginAttempt(BE.User user)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("id", user.Id);
                parametros[1] = new SqlParameter("intentos", user.Attempts);
                accesso.Write("Update_Intento", parametros);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Sucedió un error en DAL", ex);
            }

        }
    }
}
