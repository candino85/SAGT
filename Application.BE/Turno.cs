using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Turno : IEntity
    {
        public int client { get; set; }
        public char estado { get; set; }
        public int sucursal { get; set; }
        public int profesional { get; set; }
        public int estudio { get; set; }
        public int agenda { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaTurno { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int Id { get; set; }
    }
}
