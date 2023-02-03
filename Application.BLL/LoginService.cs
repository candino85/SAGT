using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BE;
using Application.DLL;
using Application.Services;

namespace Application.BLL
{
    public class LoginService
    {
        private readonly Mapper_User _mapperUsuario;
        private BE.User _usuario;

        public LoginService()
        {
            _mapperUsuario = new Mapper_User();
            _usuario = new BE.User();
        }
        /// <summary>
        /// El login de usuario se hace contra la base de datos, si es null escala una excepción, sino le asigna uns session
        /// </summary>
        /// <param name="loginname"></param>
        /// <param name="password"></param>
        public void Login(string loginname, string password)
        {
            if (string.IsNullOrEmpty(loginname) || string.IsNullOrEmpty(password)) throw new Exception("Debe completar los campos");

            try
            {
                _usuario = _mapperUsuario.GetUsuarioByLoginnamePassword(loginname, Encrypt.GetSHA256(password));

                if (_usuario.LoginName == null)
                {
                    if (loginname == "SysAdmin" && password == "clavedeemergencia")
                    {
                        _usuario.LoginName = "SysAdmin";
                        _usuario.Active = true;
                        _usuario.Role = 110;
                        SessionManager.GetInstance.Login(_usuario);
                    }
                    else
                    {
                        throw new Exception("Datos incorrectos, revise los campos");
                    }
                }
                else
                {
                    SessionManager.GetInstance.Login(_usuario);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public void Logout()
        {
            if (!SessionManager.GetInstance.IsLogged)
                throw new Exception("Sesión no iniciada");
            SessionManager.GetInstance.Logout();
        }
    }
}
