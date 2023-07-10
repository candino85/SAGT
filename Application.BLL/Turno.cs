using Application.BE;
using Application.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BLL
{
    public class Turno
    {
        mapper_Turno _mapper;

        public Turno() 
        {
            _mapper = new mapper_Turno();
        }  
        public List<BE.Turno> TurnoList()
        {
            List<BE.Turno> turnos = _mapper.GetTurnos();
            return turnos;
        }

        public List<BE.Turno> GetTurnosByEstudio(int estudio)
        {
            List<BE.Turno> turnos = _mapper.GetByEstudio(estudio);
            return turnos;
        }

        public bool TurnoCreate(BE.Turno turno)
        {
            int fa = _mapper.Create(turno);
            if (fa != 0)
                return true;
            else
                return false;
        }
    }
}
