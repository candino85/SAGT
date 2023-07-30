using Application.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BLL
{
    public class Especialidad
    {
        BE.Especialidad _especialidad;
        readonly mapper_Especialidad _mapper;

        public Especialidad()
        {
            _mapper = new mapper_Especialidad();
        }

        public BE.Especialidad GetEspecialidadById(int id)
        {
            _especialidad = new BE.Especialidad();
            _especialidad = _mapper.GetEspecialidadlById(id);
            return _especialidad;
        }

        public bool EspecialidadCreate(BE.Especialidad especialidad)
        {
            int fa = _mapper.Create(especialidad);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool EspecialidadUpdate(BE.Especialidad especialidad)
        {
            int fa = _mapper.Update(especialidad);
            if (fa != 0)
                return true;
            else
                return false;
        }

        //public bool EntityRemove(int id)
        //{
        //    int fa = _mapper.Remove(id);
        //    if (fa != 0)
        //        return true;
        //    else
        //        return false;
        //}

        public List<BE.Especialidad> EspecialidadList()
        {
            List<BE.Especialidad> listaEspecialidades = _mapper.List();
            return listaEspecialidades;
        }
    }
}
