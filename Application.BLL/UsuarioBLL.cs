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
    public class UsuarioBLL
    {
        UsuarioBE _usuario;
        readonly Mapper_Usuario _mapper;

        public UsuarioBLL()
        {
            _mapper = new Mapper_Usuario();   
        }

        public UsuarioBE GetUsuarioById(int id)
        {
            _usuario = new UsuarioBE();
            _usuario = _mapper.GetUsuarioById(id);
            return _usuario;
        }

        public bool CrearUsuario(UsuarioBE usuario)
        {
            int fa = _mapper.Crear(usuario);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool ModificarUsuario(UsuarioBE usuario)
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
        public List<UsuarioBE> Listar()
        {
            List<UsuarioBE> listaUsuarios = _mapper.Listar();
            return listaUsuarios;
        }
    }
}
