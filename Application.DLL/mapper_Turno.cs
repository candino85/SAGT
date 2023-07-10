using Application.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Application.DLL
{
    public class mapper_Turno
    {
        readonly DBAccess accesso = new DBAccess();

        public List<Turno> GetTurnos()
        {
            List<Turno> turnos = new List<Turno>();

            try
            {
                DataTable dataTable = accesso.Read("TurnosGet", null);

                foreach (DataRow row in dataTable.Rows)
                {
                    Turno turno = new Turno
                    {
                        Id = int.Parse(row["id"].ToString()),
                        client = int.Parse(row["cliente"].ToString()),
                        estado = char.Parse(row["estado"].ToString()),
                        sucursal = int.Parse(row["entidad"].ToString()),
                        estudio = int.Parse(row["estudio"].ToString()),
                        agenda = int.Parse(row["agenda"].ToString()),
                        fechaCreacion = DateTime.Parse(row["fechaHoraCreacion"].ToString()),
                        fechaTurno = DateTime.Parse(row["fechaHoraTurno"].ToString()),
                        fechaEntrega = DateTime.Parse(row["fechaHoraEntrega"].ToString()),
                    };
                    turnos.Add(turno);
                }
                return turnos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Turno> GetByEstudio(int estudio)
        {
            List<Turno> turnos = new List<Turno>();

            try
            {
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@estudio", estudio);

                DataTable dataTable = accesso.Read("TurnosGetByEstudio", parameter);

                foreach (DataRow row in dataTable.Rows)
                {
                    Turno turno = new Turno
                    {
                        Id = int.Parse(row["id"].ToString()),
                        client = int.Parse(row["cliente"].ToString()),
                        estado = char.Parse(row["estado"].ToString()),
                        sucursal = int.Parse(row["entidad"].ToString()),
                        estudio = int.Parse(row["estudio"].ToString()),
                        agenda = int.Parse(row["agenda"].ToString()),
                        fechaCreacion = DateTime.Parse(row["fechaHoraCreacion"].ToString()),
                        fechaTurno = DateTime.Parse(row["fechaHoraTurno"].ToString()),
                        fechaEntrega = DateTime.Parse(row["fechaHoraEntrega"].ToString()),
                    };
                    turnos.Add(turno);
                }
                return turnos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Create(BE.Turno turno)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[8];
                parameters[0] = new SqlParameter("cliente", turno.client);
                parameters[1] = new SqlParameter("estado", turno.estado);
                parameters[2] = new SqlParameter("entidad", turno.sucursal);
                parameters[3] = new SqlParameter("estudio", turno.estudio);
                parameters[4] = new SqlParameter("agenda", turno.agenda);
                parameters[5] = new SqlParameter("fechaHoraCreacion", turno.fechaCreacion);
                parameters[6] = new SqlParameter("fechaHoraTurno", turno.fechaTurno);
                parameters[7] = new SqlParameter("fechaHoraEntrega", turno.fechaEntrega);

                return accesso.Write("TurnoCrear", parameters);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
