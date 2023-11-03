using Application.ABSTRACTIONS;
using System.Collections.Generic;

namespace Application.Services
{
    public class UserPermission : IEntity
    {
        List<Component> _permissions;

        public int Id { get; set; }
        public string Nombre { get; set; }

        public UserPermission()
        {
            _permissions = new List<Component>();
        }

        public List<Component> Permissions
        {
            get { return _permissions; }
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
