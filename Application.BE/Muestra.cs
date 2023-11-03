using Application.ABSTRACTIONS;
using System;

namespace Application.BE
{
    public class Muestra : IEntity
    {
        public int Id { get; set; }
        public int IdTurno { get; set; }
        public string Usuario { get; set; }
        public DateTime Fechahora { get; set; }
        public string Operacion { get; set; }
        public byte[] QR { get; set; }
    }
}
