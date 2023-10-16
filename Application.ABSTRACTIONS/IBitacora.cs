using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ABSTRACTIONS
{
    public interface IBitacora
    {
        int IdUsuario { get; set; }   
        
        string LoginName { get; set; }

        DateTime FechaHora { get; set; }

        string Modulo { get; set; }

        string Operacion { get; set; }

        int Criticidad { get; set; }

        string Mensaje { get; set; }

    }
}
