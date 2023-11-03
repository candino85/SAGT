using Application.ABSTRACTIONS;

namespace Application.BE
{
    public class Sucursal : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Cuit { get; set; }
        public bool Active { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
