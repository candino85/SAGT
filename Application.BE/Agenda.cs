using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Agenda : IEntity
    {
        public int Id { get; set; }
        public DateTime fechaDesde {get;set;}
        public DateTime fechaHasta { get; set; }
        public int estudio { get; set; }
        public int entidad { get; set; }
    }
}
