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
    public class User
    {
        BE.User _usuario;
        readonly Mapper_Usuario _mapper;

        public User()
        {
            _mapper = new Mapper_Usuario();   
        }

        public BE.User GetUsuarioById(int id)
        {
            _usuario = new BE.User();
            _usuario = _mapper.GetUsuarioById(id);
            return _usuario;
        }

        public bool CrearUsuario(BE.User usuario)
        {
            int fa = _mapper.Crear(usuario);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool ModificarUsuario(BE.User usuario)
        {
            int fa = _mapper.Modificar(usuario);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool EliminarUsuario(int id)
        {
            int fa = _mapper.Eliminar(id);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public List<BE.User> Listar()
        {
            List<BE.User> listaUsuarios = _mapper.Listar();
            return listaUsuarios;
        }
    }
}
