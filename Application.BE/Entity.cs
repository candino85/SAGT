using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Entity : IEntity
    {
        public int Id { get ; set ; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Cuit { get; set; }
        public bool Active { get; set; }
    }
}
