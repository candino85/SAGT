using Application.DLL;
using System.Collections.Generic;

namespace Application.BLL
{
    public class Sucursal
    {
        BE.Sucursal _sucursal;
        readonly Mapper_Sucursal _mapper;

        public Sucursal()
        {
            _mapper = new Mapper_Sucursal();
        }

        public BE.Sucursal GetSucursalById(int id)
        {
            _sucursal = new BE.Sucursal();
            _sucursal = _mapper.GetlById(id);
            return _sucursal;
        }

        public bool SucursalCreate(BE.Sucursal entidad)
        {
            int fa = _mapper.Create(entidad);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool SucursalUpdate(BE.Sucursal sucursal)
        {
            int fa = _mapper.Update(sucursal);
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
        public List<BE.Sucursal> SucursalList()
        {
            List<BE.Sucursal> listaSucursales = _mapper.List();
            return listaSucursales;
        }
    }
}
