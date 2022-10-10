using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class Permission : Component
    {
        public Permission()
        {

        }

        public override void AddChild(Component c)
        {
        
        }
        public override void RemoveChild(Component c)
        {

        }
        public override IList<Component> GetChilds
        {
            get { return new List<Component>(); }
        }
    }
}
