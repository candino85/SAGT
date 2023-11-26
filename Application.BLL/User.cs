using Application.DLL;
using Application.Services;
using System;
using System.Collections.Generic;

namespace Application.BLL
{
    public class User
    {
        BE.User _usuario;
        readonly Mapper_User _mapper;
        private Bitacora _bitacora;
        private IntegrityRepository _integrityRepo;
        private LanguageService languageService;

        public User()
        {
            _mapper = new Mapper_User();
            _bitacora = new Bitacora();
            _integrityRepo = new DLL.IntegrityRepository();
            languageService = new LanguageService();
        }

        public string LogIn(string username, string password)
        {
            var user = _mapper.GetByLoginName(username);                //obtengo el usuario

            if (SessionManager.GetInstance.IsLogged)                    //si ya se encuentra iniciada una sesión
            {
                _bitacora.LogEvent(user.Id, "Auth", "Log In", 4, "Ya existe una sesión iniciada.");
                return "Ya existe una sesión iniciada.";
            }
            else if (user.Name == null)                                 //si el usuario no existe
            {
                if (username == "sysadmin" && password == "nomeolvides")
                {
                    user.LoginName = username;
                    user.Name = "sysadmin";
                    user.Lastname = "Administrador por defecto del sistema";
                    user.Language = languageService.GetLanguage("Español");

                    SessionManager.GetInstance.Login(user);
                    _bitacora.LogEvent(user.Id, "Auth", "Log In", 1, $"El usuario administrador por defecto {username} se logueo correctamente.");
                    return $"Bienvenido {user.Name} {user.Lastname}";
                }
                else 
                { 
                    _bitacora.LogEvent(0, "Auth", "Log In", 3, $"El usuario {username} no existe.");
                    return $"El usuario '{username}' no existe.";
                }
            }
            else if (!user.Active)                                      //si el usuario está inactivo
            {
                _bitacora.LogEvent(user.Id, "Auth", "Log In", 2, $"El usuario {username} se encuentra inactivo.");
                return $"El usuario {username} se encuentra inactivo, contacte a RRHH.";
            }
            else if (user.Blocked)
            {
                _bitacora.LogEvent(user.Id, "Auth", "Log In", 2, $"El usuario {username} se encuentra bloqueado.");
                return $"El usuario {username} se encuentra bloqueado, contacte a un administrador para desbloquearlo.";
            }
            else if (Encrypt.GetSHA256(password).Equals(user.Password)) // si no se cumple ninguno de los anteriores inicio sesión
            {
                SessionManager.GetInstance.Login(user);
                user.Attempts = 0;
                _mapper.Update(user);
                //_integrityRepo.SetDV("Usuarios");

                _bitacora.LogEvent(user.Id, "Auth", "Log In", 1, $"El usuario {username} se logueo correctamente.");
                return $"Bienvenido {user.Name} {user.Lastname}";
            }
            else                                                        //si la clave ingresada no coicide con la del usuario
            {
                user.Attempts++;
                var msg = "Contraseña incorrecta";
                if ((user.Attempts) < 3)                                //si la cantidad de intentos es menor a 3
                    msg += $", le quedan {3 - user.Attempts} intentos restantes antes de bloquear su usuario.";
                FailLoginAttempt(user);
                if ((user.Attempts) > 2)                                //si la cantidad de intentos es mayor a 2
                {
                    user.Blocked = true;
                    _mapper.Update(user);
                    _bitacora.LogEvent(user.Id, "Auth", "Log In", 4, $"El usuario {username} ha sido bloqueado.");
                    msg += ", el usuario ha sido bloqueado.";
                    //_integrityRepo.SetDV("Usuarios");
                }
                _bitacora.LogEvent(user.Id, "Auth", "Log In", 3, $"El usuario {username} ingresó incorrectamente la contraseña.");
                return msg;
            }
        }

        public void LogOut()
        {
            if (!SessionManager.GetInstance.IsLogged)
                throw new Exception("No hay sesión iniciada");      //doble validación, anulo en boton en formulario y valido en la bll
            _bitacora.LogEvent(SessionManager.GetInstance.Usuario.Id, "Auth", "Log Out", 1, $"El usuario {SessionManager.GetInstance.Usuario.LoginName} ha finalizado su sesión correctamente.");
            SessionManager.GetInstance.Logout();

        }

        public string UpdatePassword(BE.User usrA, BE.User usrN)
        {
            var result = _mapper.UpdatePassword(usrA.LoginName, usrN.Password);
            if (result != 0)
            {
                _bitacora.LogEvent(usrA.Id, "Administracion", "Actualización de clave de usuario", 3, $"El usuario {usrA.LoginName} ha cambiado su clave correctamente.");
                _integrityRepo.SetDV("Usuarios");
                return "CM";
            }
            else
                return "HP";
        }

        public string UpdatePassword(string passA, string passN)
        {
            if (SessionManager.GetInstance.Usuario.Password == Encrypt.GetSHA256(passA))
            {
                var result = _mapper.UpdatePassword(SessionManager.GetInstance.Usuario.LoginName, Encrypt.GetSHA256(passN));
                if (result != 0)
                {
                    _bitacora.LogEvent(SessionManager.GetInstance.Usuario.Id, "Administracion", "Actualización de clave de usuario", 3, $"El usuario {SessionManager.GetInstance.Usuario.LoginName} ha cambiado su clave correctamente.");
                    _integrityRepo.SetDV("Usuarios");
                    return "CM";
                }
                else
                    return "HP";
            }
            else
                return "CI";
        }

        public void FailLoginAttempt(BE.User user)
        {
            _mapper.FailLoginAttempt(user);
            _integrityRepo.SetDV("Usuarios");
            _bitacora.LogEvent(user.Id, "Auth", "Fallo de Log In", 3, $"El usuario {user.LoginName} ha ingresado mal la clave {user.Attempts} vez/veces.");
        }

        //public BE.User GetUsuarioById(int id)
        //{
        //    _usuario = new BE.User();
        //    _usuario = _mapper.GetUsuarioById(id);
        //    return _usuario;
        //}

        public BE.User GetByLoginName(string loginname)
        {
            return _mapper.GetByLoginName(loginname);
        }

        public int UserCreate(BE.User usuario)
        {
            int fa = _mapper.Create(usuario);
            if (fa != 0)
            {
                _bitacora.LogEvent(usuario.Id, "Administracion", "Creación de usuario", 2, $"El usuario {usuario.LoginName} se ha creado correctamente.");
                _integrityRepo.SetDV("Usuarios");
                return fa;
            }
            else
                return 0;
        }

        public bool UserUpdate(BE.User usuario, string msg)
        {
            int fa = _mapper.Update(usuario);
            if (fa != 0)
            {
                _bitacora.LogEvent(usuario.Id, "Idioma", $"{msg}", 2, $"El usuario {usuario.LoginName} se ha modificado correctamente.");
                _integrityRepo.SetDV("Usuarios");
                return true;
            }
            else
                return false;
        }

        //public bool UserRemove(int id)
        //{
        //    int fa = _mapper.Remove(id);
        //    if (fa != 0)
        //        return true;
        //    else
        //        return false;
        //}

        public List<BE.User> UserList()
        {
            List<BE.User> listaUsuarios = _mapper.List();
            return listaUsuarios;
        }

        public int[] UserExist(string loginname, string email, string dni)
        {
            var result = _mapper.UserExist(loginname, email, dni);

            return result;
        }

        public BE.User GetUserById(int id)
        {
            return _mapper.GetUsuarioById(id);
        }
    }
}
