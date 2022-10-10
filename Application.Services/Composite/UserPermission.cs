using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services 
{
    public class UserPermission : IEntity
    {
        List<Component> _permissions;

        public int Id { get ; set ; }
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
