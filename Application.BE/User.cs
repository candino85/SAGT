using Application.ABSTRACTIONS;
using System;

namespace Application.BE
{
    public class User : IEntity, IUser, IEquatable<User>, IDigitoVerificador
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


        private Language _language;
        public Language Language { get { return _language; } set { _language = value; } }

        private int _role;
        public int Role
        {
            get { return _role; }
            set { _role = value; }
        }

        private Sucursal _entity;

        public Sucursal Entity
        {
            get { return _entity; }
            set { _entity = value; }
        }

        private bool _blocked;

        public bool Blocked
        {
            get { return _blocked; }
            set { _blocked = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private int _attempts;

        public int Attempts
        {
            get { return _attempts; }
            set { _attempts = value; }
        }

        public string DVH { get; set; }
        public string DVV { get ; set ; }

        public override string ToString()
        {
            return LoginName;
        }


        //Composite
        //private Role _rol;
        //public Role Rol { get { return _rol; } set { _rol = value; } }

        public bool Equals(User other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _name == other._name && _lastname == other._lastname && _idUser == other._idUser &&
                   _address == other._address && _loginName == other._loginName && _email == other._email &&
                   _active == other._active && _blocked == other._blocked &&
                   Equals(_language, other._language) && _role == other._role && Equals(_entity, other._entity);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User)obj);
        }


    }
}

