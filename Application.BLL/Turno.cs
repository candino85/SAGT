using Application.DLL;
using System.Collections.Generic;

namespace Application.BLL
{
    public class Turno
    {
        mapper_Turno _mapper;
        private IntegrityRepository _integrityRepo;
        public Turno()
        {
            _mapper = new mapper_Turno();
            _integrityRepo = new IntegrityRepository();
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

        public List<BE.Turno> GetTurnosByEstudioSucursal(int estudio, int sucursal)
        {
            List<BE.Turno> turnos = _mapper.GetByEstudioSucursal(estudio, sucursal);
            return turnos;
        }

        public bool TurnoCreate(BE.Turno turno, BE.User user)
        {
            int fa = _mapper.Create(turno, user);
            if (fa != 0)
            {
                _integrityRepo.SetDV("Turno");
                return true;
            }
            else
                return false;
        }

        public bool TurnoUpdate(BE.Turno turno, BE.User user)
        {
            int fa = _mapper.Update(turno, user);
            if (fa != 0)
            {
                _integrityRepo.SetDV("Turno");
                return true;
            }
            else
                return false;
        }
        public bool TurnoEliminar(BE.Turno turno, BE.User user)
        {
            int fa = _mapper.Delete(turno, user);
            if (fa != 0)
            {
                _integrityRepo.SetDV("Turno");
                return true;
            }
            else
                return false;
        }

        public List<BE.TurnoHistorico> GetTurnosHistorico()
        {
            List<BE.TurnoHistorico> turnosHistorico = _mapper.GetAllHistorico();

            return turnosHistorico;
        }
        public List<BE.TurnoHistorico> GetTurnosHistorico(BE.FiltroHistorico filtro)
        {
            List<BE.TurnoHistorico> turnosHistorico = _mapper.GetChanges(filtro);
            return turnosHistorico;
        }
    }
}
