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

        public User GetUsuarioByLoginnamePassword(string loginname, string password)
        {
            User usuario = new User();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@loginname", loginname);
            parameters[1] = new SqlParameter("@password", password);
            DataTable dataTable = accesso.Leer("UsuarioGetByLoginnamePassword", parameters);
            foreach (DataRow row in dataTable.Rows)
            {
                usuario.Id = int.Parse(row["id"].ToString());
                usuario.DNI = row["dni"].ToString();
                usuario.Nombre = row["nombre"].ToString();
                usuario.Nombre = row["apellido"].ToString();
                usuario.LoginName = row["Loginname"].ToString();
                usuario.Password = row["Password"].ToString();
            }
            return usuario;
        }

        public User GetUsuarioById(int id)
        {
            BE.User usuario = new User();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@id", id);

            DataTable dataTable = accesso.Leer("UsuarioGetById", parametro);
            foreach (DataRow row in dataTable.Rows)
            {
                usuario.Id = int.Parse(row["Id"].ToString());
                usuario.Nombre = row["Name"].ToString();
                usuario.LoginName = row["Loginname"].ToString();
                usuario.Password = row["Password"].ToString();
            }
            return usuario;
        }

        public int Crear(User usuario)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("Nombre",usuario.Nombre);
            parametros[1] = new SqlParameter("Apellido",usuario.Apellido);
            parametros[2] = new SqlParameter("DNI",usuario.DNI);
            parametros[3] = new SqlParameter("Loginname",usuario.LoginName);
            parametros[4] = new SqlParameter("Password",usuario.Password);

            return accesso.Escribir("UsuarioCrear", parametros);
        }

        public int Modificar(User usuario)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("Id", usuario.Id); 
            parametros[1] = new SqlParameter("DNI", usuario.DNI);
            parametros[2] = new SqlParameter("Nombre", usuario.Nombre); 
            parametros[3] = new SqlParameter("Apellido", usuario.Apellido); 
            parametros[4] = new SqlParameter("Loginname", usuario.LoginName); 
            parametros[5] = new SqlParameter("Password", usuario.Password);

            return accesso.Escribir("UsuarioModificar", parametros);
        }

        public int Eliminar(int id)
        {
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("Id", id);
            
            return accesso.Escribir("UsuarioEliminar", parametro);
        }

        public List<User> Listar()
        {
            List<User> listaUsuarios = new List<User>();
            DataTable dataTable = accesso.Leer("UsuarioListar", null);

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
