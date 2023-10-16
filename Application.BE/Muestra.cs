using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Muestra: IEntity
    {        
        public int Id { get ; set ; }
        public int IdTurno { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fechahora { get; set; }
        public byte[] QR { get; set; }
        public string DVH { get; set; }
    }
}
