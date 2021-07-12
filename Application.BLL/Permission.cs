using Application.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BLL
{
    public class Permission
    {
        //BE.Permission _permission;
        readonly Mapper_Permission _mapper;

        public Permission()
        {
            _mapper = new Mapper_Permission();
        }

        public bool CrearPermiso(BE.Permission permiso)
        {
            int fa = _mapper.Crear(permiso);
            if (fa != 0)
                return true;
            else
                return false;
        }

        public bool EditarPermiso(BE.Permission permiso)
        {
            int fa = _mapper.Editar(permiso);
            if (fa != 0)
                return true;
            else
                return false;
        }

        public List<BE.Permission> Listar()
        {
            List<BE.Permission> permisos = _mapper.Listar();
            return permisos;
        }

    }
}
