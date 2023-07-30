using System;
using System.Collections.Generic;
using Application.DLL;
using Application.Services;

namespace Application.BLL
{
    public class User
    {
        BE.User _usuario;
        readonly Mapper_User _mapper;

        public User()
        {
            _mapper = new Mapper_User();   
        }

        public string LogIn(string username, string password)
        {
            var user = _mapper.GetByLoginName(username);                //obtengo el usuario
            
            if (SessionManager.GetInstance.IsLogged)                    //si ya se encuentra iniciada una sesión
                return "Ya existe una sesión iniciada.";
            else if (user.Name == null)                                 //si el usuario no existe
                return $"El usuario '{username}' no existe.";
            else if (!user.Active)                                      //si el usuario está inactivo
                return "El usuario se encuentra inactivo, contacte a RRHH.";
            else if (user.Blocked)
                return "El usuario se encuentra bloqueado, contacte a un administrador para desbloquearlo.";
            else if (Encrypt.GetSHA256(password).Equals(user.Password)) // si no se cumple ninguno de los anteriores inicio sesión
            {
                SessionManager.GetInstance.Login(user);
                user.Attempts = 0;
                _mapper.Update(user);
                return $"Bienvenido {user.Name} {user.Lastname}";
            }
            else                                                        //si la clave ingresada no coicide con la del usuario
            {
                user.Attempts++;
                var msg = "Contraseña incorrecta";
                if ((user.Attempts) < 3)                                    //si la cantidad de intentos es menor a 3
                    msg += $", le quedan {3 - user.Attempts} intentos restantes antes de bloquear su usuario.";
                FailLoginAttempt(user);
                if ((user.Attempts) > 2)                                    //si la cantidad de intentos es mayor a 2
                { 
                    user.Blocked = true;
                    _mapper.Update(user);
                    msg += ", el usuario ha sido bloqueado.";
                }
                return msg;
            }
        }

        public void LogOut()
        {
            if (!SessionManager.GetInstance.IsLogged)
                throw new Exception("No hay sesión iniciada");      //doble validación, anulo en boton en formulario y valido en la bll
            SessionManager.GetInstance.Logout();
        }

        public string UpdatePassword(BE.User usrA, BE.User usrN)
        {
                var result = _mapper.UpdatePassword(usrA.LoginName, usrN.Password);
                if (result != 0)
                {                    
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
                return fa;
            }
            else
                return 0;
        }
        public bool UserUpdate(BE.User usuario)
        {
            int fa = _mapper.Update(usuario);
            if (fa != 0)
                return true;
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
    }
}
