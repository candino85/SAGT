using Application.ABSTRACTIONS;

namespace Application.BE
{
    public class Especialidad : IEntity
    {
        public string Descripcion { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
