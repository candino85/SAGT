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
        private Guid guid;
        public Guid Guid { get { return guid; } set { guid = value; } }

        private int _id;
        public int Id { get { return _id; } set { _id = value; } }

        private string _dni;
        public string DNI { get { return _dni; } set { _dni = value; } }

        private DateTime _creationDate;
        public DateTime CreationDate { get {return _creationDate;} set { _creationDate = value; } }

        private string _nombre;
        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        private string _apellido;
        public string Apellido { get { return _apellido; } set { _apellido = value; } }

        private string _loginName;
        public string LoginName { get { return _loginName; } set { _loginName = value; } }

        private string _password;
        public string Password { get { return _password; } set { _password = value; } }
        private Role _rol;
        public Role Rol { get { return _rol; } set { _rol = value; } }
        public string FullName { get { return $"{_apellido}, {_nombre}"; } }
        public List<Component> Permisos { get; set; }

        private Language _idioma;
        public Language Idioma { get { return _idioma; } set { _idioma = value; } }

    }
}
