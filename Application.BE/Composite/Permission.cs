using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Permission : Component
    {
        public string Menu { get; set; }
        public Permission(int id, string nombre, Role padre) : base(id, nombre, padre)
        {
            
        }

        public Permission(string nombre, Role padre) : base(nombre, padre)
        {

        }
        public override void AddHijo(Component c)
        {
            throw new NotImplementedException();
        }
        public override void RemoveHijo(Component c)
        {
            throw new NotImplementedException();
        }
        public override IList<Component> GetHijos()
        {
            return null;
        }
        public override Permission GetPermission(string nombre)
        {
            return this;
        }
    }
}
