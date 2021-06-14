using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Role : Component
    {
        private readonly IList<Component> _listaHijos;

        public Role(int id, string nombre, Role padre) : base(id, nombre, padre)
        {
            _listaHijos = new List<Component>();
        }
        public Role(string nombre, Role padre) : base(nombre, padre)
        {
            _listaHijos = new List<Component>();
        }
        public override IList<Component> GetHijos()
        {
            return _listaHijos.ToArray();
        }

        public override void AddHijo(Component c)
        {
            if (!_listaHijos.Contains(c))
                _listaHijos.Add(c);
        }
        public override void RemoveHijo(Component c)
        {
            if(_listaHijos.Contains(c))
                _listaHijos.Remove(c);
        }
        public override Permission GetPermission(string nombre)
        {
            Permission permission = (Permission)_listaHijos.FirstOrDefault(p => p.Nombre == nombre);
            return permission;
        }

        /// <summary>
        /// Llamada recursiva para obtener todos los permisos del arbol
        /// </summary>
        /// <returns></returns>
        //public List<int> GetPermiso()
        //{
        //    List<int> _listaPermisos = new List<int>();
        //    foreach (Permission permiso in _listaHijos)
        //    {
        //        _listaPermisos.Add(permiso.GetPermiso());
        //    };
        //    return _listaPermisos;
        //}
    }
}
