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
        
        private string _name;
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Cuit { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return _name;
        }
    }
}
