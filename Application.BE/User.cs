using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class User : IEntity, IUser
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        
        private string _lastname;
        public string Lastname { get { return _lastname; } set { _lastname = value; } }
        
        private string _idUser;
        public string DNI { get { return _idUser; } set { _idUser = value; } }
        
        private bool _active;
        public bool Active { get { return _active; } set { _active = value; } }
        
        private DateTime _creationDate;
        public DateTime CreationDate { get { return _creationDate; } set { _creationDate = value; } }

        private string _address;
        public string Address { get { return _address; } set { _address = value; } }


        private string _loginName;
        public string LoginName { get { return _loginName; } set { _loginName = value; } }
        private string _password;
        public string Password { get { return _password; } set { _password = value; } }

        public string FullName { get { return $"{_lastname}, {_name}"; } }

        //Idiomas
        private Language _idioma;
        public Language Idioma { get { return _idioma; } set { _idioma = value; } }

        //Composite
        //private Role _rol;
        //public Role Rol { get { return _rol; } set { _rol = value; } }
        //public List<Component> Permisos { get; set; }
        
    }
}

