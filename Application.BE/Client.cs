using Application.ABSTRACTIONS;
using System;

namespace Application.BE
{
    public class Client : IEntity, IPerson
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

        public string FullName { get { return $"{_lastname}, {_name}"; } }

        public string Email { get; set; }
    }
}
