using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Rol : Componente
    {
        private IList<Componente> _listaHijos;

        public Rol(int id, string nombre, Rol padre) : base(id, nombre, padre)
        {
            _listaHijos = new List<Componente>();
        }
        public override IList<Componente> GetHijos()
        {
            return _listaHijos.ToArray();
        }

        public override void AddHijo(Componente c)
        {
            _listaHijos.Add(c);
        }

        public List<int> GetPermiso()
        {
            List<int> _listaPermisos = new List<int>();
            foreach (Permiso permiso in _listaHijos)
            {
                _listaPermisos.Add(permiso.GetPermiso());
            };
            return _listaPermisos;
        }
    }
}
