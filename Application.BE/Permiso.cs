using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Permiso : Componente
    {
        public string Menu { get; set; }
        public Permiso(int id, string nombre, Rol padre) : base(id, nombre, padre)
        {
            //this.permiso = permiso;
        }
        public override void AddHijo(Componente c)
        {
        }

        public override IList<Componente> GetHijos()
        {
            return null;
        }
        public int GetPermiso()
        {
            return this.Id;
        }
    }
}
