using Application.DLL;
using Application.Services.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BLL
{
    public class Bitacora
    {
        private static Bitacora _instance;
        private BitacoraRepository _mapper;

        public Bitacora()
        {
            _mapper = new BitacoraRepository();
        }

        public static Bitacora Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Bitacora();
                }
                return _instance;
            }
        }

        public List<BE.Bitacora> GetAll()
        {
            _mapper = new BitacoraRepository();

            return _mapper.GetAllEvents();
        }

        public List<BE.Bitacora> Get(BE.Filtro filtro)
        {
            _mapper = new BitacoraRepository();
            return _mapper.GetEvents(filtro);
        }

        public void LogEvent(int usuario, string modulo, string operacion, int criticidad, string msj)
        {
            _mapper.LogEvent(usuario, modulo, operacion, criticidad, msj);
        }
    }
}
