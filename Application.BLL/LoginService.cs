﻿using System;
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
        private readonly Mapper_Usuario _mapperUsuario;
        private UsuarioBE _usuario;

        public LoginService()
        {
            _mapperUsuario = new Mapper_Usuario();
            _usuario = new UsuarioBE();
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
                    _usuario = _mapperUsuario.GetUsuarioByLoginnamePassword(loginname, Encriptacion.GetSHA256(password));
                    if (_usuario.LoginName == null)
                    {
                        throw new Exception("El usuario o contraseña son incorrectos");
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
            SessionManager.GetInstance.Logout();
        }
    }
}