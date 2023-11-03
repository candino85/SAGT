using Application.ABSTRACTIONS;

namespace Application.BE
{
    public class Area : IEntity
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }

        public string Name { get; set; }

        private string _description;
        public string Description { get { return _description; } set { _description = value; } }

        private Sucursal _entity;

        public Sucursal Entity
        {
            get { return _entity; }
            set { _entity = value; }
        }

        public bool Active { get; set; }
    }
}
