using Application.ABSTRACTIONS;
using System.Collections.Generic;

namespace Application.Services
{
    public abstract class Component : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Parent { get; set; }
        public abstract IList<Component> GetChild { get; }
        public abstract void AddChild(Component c);
        public abstract void RemoveChild(Component c);
        public PermissionType Permission { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
