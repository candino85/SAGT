using Application.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DLL
{
    public class mapper_Agenda
    {
        readonly DBAccess accesso = new DBAccess();
        public List<Agenda> GetByEstudio(int estudio)
        {
            List<Agenda> agendas = new List<Agenda>();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@estudio",estudio);

            try
            {
                DataTable dataTable = accesso.Read("AgendaGet", parameter);

                foreach (DataRow row in dataTable.Rows)
                {
                    Agenda agenda = new Agenda
                    {
                        Id = int.Parse(row["id"].ToString()),
                        fechaDesde = (DateTime)row["fechaDesde"],
                        fechaHasta = (DateTime)(DateTime)row["fechaHasta"],
                        estudio = (int)row["estudio"]
                    };
                    agendas.Add(agenda);
                }
                return agendas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Create(BE.Agenda agenda)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("estudio", agenda.estudio);
                parameters[1] = new SqlParameter("fechaDesde", agenda.fechaDesde);
                parameters[2] = new SqlParameter("fechaHasta", agenda.fechaHasta);

                return accesso.Write("AgendaCrear", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
