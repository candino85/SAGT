using Application.DLL;
using System;
using System.Collections.Generic;
using System.Data;

namespace Application.BLL
{
    public class Area
    {
        BE.Area _area;
        readonly Mapper_Area _mapper;

        public Area()
        {
            _mapper = new Mapper_Area();
        }

        public BE.Area GetAreaById(int id)
        {
            try
            {
                _area = new BE.Area();
                _area = _mapper.GetAreaById(id);
                return _area;
            }
            catch (DataException dae) { throw dae; }
            catch (Exception ex) { throw new BusinessLogicException("Sucedió un error en la BLL", ex); }
        }

        public BE.Area GetAreaByName(BE.Area area)
        {
            try
            {
                _area = _mapper.GetAreaByName(area);
                return _area;
            }
            catch (DataException dae) { throw dae; }
            catch (Exception ex) { throw new BusinessLogicException("Sucedió un error en la BLL", ex); }
        }

        public bool AreaCreate(BE.Area area)
        {
            try
            {
                int fa = _mapper.Create(area);
                if (fa != 0)
                    return true;
                else
                    return false;
            }
            catch (DataException dae) { throw dae; }
            catch (Exception ex) { throw new BusinessLogicException("Sucedió un error en la BLL", ex); }
        }
        public bool AreaUpdate(BE.Area area)
        {
            try
            {
                int fa = _mapper.Update(area);
                if (fa != 0)
                    return true;
                else
                    return false;
            }
            catch (DataException dae) { throw dae; }
            catch (Exception ex) { throw new BusinessLogicException("Sucedió un error en la BLL", ex); }
        }
        public bool AreaRemove(int id)
        {
            try
            {
                int fa = _mapper.Remove(id);
                if (fa != 0)
                    return true;
                else
                    return false;
            }
            catch (DataException dae) { throw dae; }
            catch (Exception ex) { throw new BusinessLogicException("Sucedió un error en la BLL", ex); }
        }
        public List<BE.Area> AreaList()
        {
            try
            {
                List<BE.Area> listaEspacios = _mapper.List();
                return listaEspacios;
            }
            catch (DataException dae) { throw dae; }
            catch (Exception ex) { throw new BusinessLogicException("Sucedió un error en la BLL", ex); }
        }
    }
}
