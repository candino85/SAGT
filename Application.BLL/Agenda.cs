using Application.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BLL
{
    public class Agenda
    {
        readonly mapper_Agenda _mapper;

        public Agenda() 
        {
            _mapper = new mapper_Agenda();
        }

        public List<BE.Agenda> GetAgendaByEstudio(int estudio)
        {
            List<BE.Agenda> agenda = _mapper.GetByEstudio(estudio);
            return agenda;
        }

        public void AgendasCreate(List<BE.Agenda> agendas)
        {
            foreach (BE.Agenda a in agendas)
            {
                _mapper.Create(a);
            }
        }

    }
}
