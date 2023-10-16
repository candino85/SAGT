using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class TurnoHistorico: IEntity
    {
        public int Id { get; set ; }
        public bool activo { get; set; }
        public DateTime FechaHora { get; set; }        
        public string Operacion { get; set; }
        public string Usuario { get; set; }
        public int idTurno { get; set; }
        public int client { get; set; }
        public char estado { get; set; }
        public int agenda { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaTurno { get; set; }
        public DateTime fechaEntrega { get; set; }        
    }

    public class FiltroHistorico
    {
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }
        public string operacion { get; set; }
        public string usuario { get; set; }
        public int estudio { get; set; }
    }
}
