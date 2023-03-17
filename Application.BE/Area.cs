using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Area : IEntity
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }

        public string Name { get; set; }

        private string _description;
        public string Description { get { return _description; } set { _description = value; } }

        private Entity _entity;

        public Entity Entity
        {
            get { return _entity; }
            set { _entity = value; }
        }

        public bool Active { get; set; }
    }
}
