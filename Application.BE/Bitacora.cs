using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Bitacora : IEntity, IBitacora
    {
        public int Id { get; set; }
        public int IdUsuario { get ; set ; }
        public string LoginName { get; set; }
        public DateTime FechaHora { get; set; }
        public string Modulo { get; set; }
        public string Operacion { get; set; }
        public int Criticidad { get; set; }    
        public string Mensaje { get; set; }
    }
    
    public class Filtro
    {
        public int IdUsuario { get; set; }
        public DateTime FechaHoraDesde { get; set; }
        public DateTime FechaHoraHasta { get; set; }
        public string Modulo { get; set; }
        public string Operacion { get; set; }
        public int Criticidad { get; set; }
    }
}
