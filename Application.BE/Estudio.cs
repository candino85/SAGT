using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Estudio: IEntity
    {
        public string Nombre { get; set; }
        public int Especialidad { get; set; }
        public int Tiempo { get; set; }
        public bool Activo { get; set; }
        public int Id { get ; set ; }
    }
}
