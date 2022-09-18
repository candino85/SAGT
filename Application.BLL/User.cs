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
        readonly Mapper_User _mapper;

        public User()
        {
            _mapper = new Mapper_User();   
        }

        public BE.User GetUsuarioById(int id)
        {
            _usuario = new BE.User();
            _usuario = _mapper.GetUsuarioById(id);
            return _usuario;
        }

        public bool UserCreate(BE.User usuario)
        {
            int fa = _mapper.Create(usuario);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool UserUpdate(BE.User usuario)
        {
            int fa = _mapper.Update(usuario);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool UserRemove(int id)
        {
            int fa = _mapper.Remove(id);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public List<BE.User> UserList()
        {
            List<BE.User> listaUsuarios = _mapper.List();
            return listaUsuarios;
        }
    }
}
