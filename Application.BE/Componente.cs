using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public abstract class Componente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Rol Padre { get; set; }
        public abstract IList<Componente> GetHijos();
        public abstract void AddHijo(Componente c);
        public Componente(int id, string nombre, Rol padre)
        {
            Id = id;
            Nombre = nombre;
            Padre = padre;
        }
        public Componente(string nombre, Rol padre)
        {
            Nombre = nombre;
            Padre = padre;
        }
    }
}
