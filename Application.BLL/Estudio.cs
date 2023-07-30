using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DLL;
using Application.BE;

namespace Application.BLL
{
    public class Estudio
    {
        BE.Estudio _estudio;
        readonly mapper_Estudio _mapper;

        public Estudio()
        {
            _mapper = new mapper_Estudio();   
        }

        public BE.Estudio GetEstudioById(int id)
        {
            _estudio = new BE.Estudio();
            _estudio = _mapper.GetById(id);
            return _estudio;
        }

        public bool EstudioCreate(BE.Estudio estudio)
        {
            int fa = _mapper.Create(estudio);
            if (fa != 0)
                return true;
            else
                return false;
        }

        public bool EstudioUpdate(BE.Estudio estudio)
        {
            int fa = _mapper.Update(estudio);
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

        public List<BE.Estudio> EstudioList()
        {
            List<BE.Estudio> estudios = _mapper.List();
            return estudios;
        }
    }
}
