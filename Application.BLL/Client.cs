using Application.DLL;
using System.Collections.Generic;

namespace Application.BLL
{
    public class Client
    {
        BE.Client cliente;
        readonly Mapper_Client _mapper;

        public Client()
        {
            _mapper = new Mapper_Client();
        }

        public BE.Client GetClientById(int id)
        {
            cliente = new BE.Client();
            cliente = _mapper.GetClientById(id);
            return cliente;
        }

        public bool ClientCreate(BE.Client entidad)
        {
            int fa = _mapper.Create(entidad);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool ClientUpdate(BE.Client entidad)
        {
            int fa = _mapper.Update(entidad);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public bool ClientRemove(int id)
        {
            int fa = _mapper.Remove(id);
            if (fa != 0)
                return true;
            else
                return false;
        }
        public List<BE.Client> ClientList()
        {
            List<BE.Client> listaEntidades = _mapper.List();
            return listaEntidades;
        }

    }
}
