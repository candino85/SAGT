using Application.ABSTRACTIONS;
using Application.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SessionManager : ILanguageSubject
    {
        private static SessionManager _session = new SessionManager();
        private readonly static object _lock = new Object();
        
        public User Usuario;
        public DateTime InicioSesion { get; set; }
        public DateTime FinSesion { get; set; }
        public bool IsLogged { get; private set; }
        public IList<ILanguageObserver> languageObservers { get ; set ; }

        private Language _language;

        public Language language 
        { 
            get { return _language; } 
            set { _language = value; } 
        }

        private SessionManager()
        {
            IsLogged = false;
            languageObservers = new List<ILanguageObserver>();
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

        public void Login(User usuario)
        {
            lock (_lock)
            {
                if (IsLogged == false)
                {                   
                    _session.Usuario = usuario;
                    _session.language = usuario.Language;
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

        public void SubscribeObserver(ILanguageObserver observer)
        {
            languageObservers.Add(observer);
        }

        public void UnsubscribeObserver(ILanguageObserver observer)
        {
            languageObservers.Remove(observer);
        }

        public void NotifyAllObservers(ILanguage language)
        {
            foreach (ILanguageObserver observer in languageObservers)
            {
                observer.updateLanguage(language);
            }
        }

        public void ChangeLanguage(Language language)
        {
            this.language = language;
            _session.Usuario.Language = language;
            NotifyAllObservers(language);
        }
    }
}
