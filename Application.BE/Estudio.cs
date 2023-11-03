using Application.ABSTRACTIONS;

namespace Application.BE
{
    public class Estudio : IEntity
    {
        public string Nombre { get; set; }
        public Especialidad Especialidad { get; set; }
        public int Tiempo { get; set; }
        public bool Activo { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
