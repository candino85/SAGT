using Application.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SessionManager
    {
        private static SessionManager _session = new SessionManager();
        private readonly static object _lock = new Object();
        public UsuarioBE Usuario = new UsuarioBE();
        public DateTime InicioSesion { get; set; }
        public DateTime FinSesion { get; set; }
        public bool IsLogged { get; private set; }

        private SessionManager()
        {
            IsLogged = false;
        }

        public static SessionManager GetInstance
        {
            get
            {
                if (_session == null)
                    _session = new SessionManager();
                return _session;
            }
        }
       
        //>> Agregar método para manejar habilitación y desabilitacion de menues segun Rol
        public void Login(UsuarioBE usuario)
        {
            lock (_lock)
            {
                if (IsLogged == false)
                {
                    usuario.Guid = Guid.NewGuid();
                    _session.Usuario = usuario;
                    _session.InicioSesion = DateTime.Now;
                    IsLogged = true;
                }
                else
                {
                    throw new Exception("La sesión ya se encuentra iniciada");
                }
            }
        }

        public void Logout()
        {
            lock (_lock)
            {
                if (IsLogged == true)
                {
                    _session.FinSesion = DateTime.Now;
                    //Mandar el fin de session a la bd
                    IsLogged = false;
                    _session.Usuario = null;
                }
                else
                {
                    throw new Exception("La sesión no se encuentra iniciada");
                }
            }
        }
    }
}
