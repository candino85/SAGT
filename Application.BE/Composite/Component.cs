using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public abstract class Component : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Role Padre { get; set; }
        public abstract IList<Component> GetHijos();
        public abstract void AddHijo(Component c);
        public abstract void RemoveHijo(Component c);
        public abstract Permission GetPermission(string nombre);
        public Component(int id, string nombre, Role padre)
        {
            Id = id;
            Nombre = nombre;
            Padre = padre;
        }
        public Component(string nombre, Role padre)
        {
            Nombre = nombre;
            Padre = padre;
        }
    }
}
