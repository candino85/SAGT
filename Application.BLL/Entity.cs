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
    public class Entity
    {
        BE.Sucursal _entidad;
        readonly Mapper_Entity _mapper;

        public Entity()
        {
            _mapper = new Mapper_Entity();   
        }

        public BE.Sucursal GetEntityById(int id)
        {
            _entidad = new BE.Sucursal();
            _entidad = _mapper.GetEntityById(id);
            return _entidad;
        }

        public bool EntityCreate(BE.Sucursal entidad)
        {
            int fa = _mapper.Create(entidad);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool EntityUpdate(BE.Sucursal entidad)
        {
            int fa = _mapper.Update(entidad);
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
        public List<BE.Sucursal> EntityList()
        {
            List<BE.Sucursal> listaEntidades = _mapper.List();
            return listaEntidades;
        }
    }
}
