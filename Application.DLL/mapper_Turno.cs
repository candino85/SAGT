using Application.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Application.DLL
{
    public class mapper_Turno
    {
        readonly DBAccess accesso = new DBAccess();

        public List<TurnoHistorico> GetAllHistorico()
        {
            var cnn = new SqlConnection(accesso.GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var query = $@"SELECT [Id]
                                 ,[FechaHora]
                                 ,[Operacion]
                                 ,[Usuario]
                                 ,[IdTurno]
                                 ,[Cliente]
								 ,[Estado]
                                 ,[Agenda]
                                 ,[FechaHoraCreacion]
                                 ,[FechaHoraTurno]
                                 ,[FechaHoraEntrega]
                                 ,[Activo]
                             FROM [dbo].[Turno_Historial]";

            cmd.CommandText = query;

            var reader = cmd.ExecuteReader();

            List<TurnoHistorico> turnosHistoricos = new List<TurnoHistorico>();
            while (reader.Read())
            {
                TurnoHistorico turno = new TurnoHistorico();
                turno.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                turno.FechaHora = reader.GetDateTime(reader.GetOrdinal("fechaHora"));
                turno.Operacion = reader.GetString(reader.GetOrdinal("Operacion"));
                turno.Usuario = reader.GetString(reader.GetOrdinal("Usuario"));

                //turno.Turno = new Turno();
                //turno.Turno.Id = reader.GetInt32(reader.GetOrdinal("IdTurno"));
                //turno.Turno.client = reader.GetInt32(reader.GetOrdinal("Cliente"));
                //turno.Turno.estado = Convert.ToChar(reader.GetValue(reader.GetOrdinal("Estado")));
                //turno.Turno.agenda = reader.GetInt32(reader.GetOrdinal("Agenda"));
                //turno.Turno.fechaCreacion = reader.GetDateTime(reader.GetOrdinal("FechaHoraCreacion"));
                //turno.Turno.fechaTurno= reader.GetDateTime(reader.GetOrdinal("FechaHoraTurno"));
                //turno.Turno.fechaEntrega = reader.GetDateTime(reader.GetOrdinal("FechaHoraEntrega"));

                turno.idTurno = reader.GetInt32(reader.GetOrdinal("IdTurno"));
                turno.client = reader.GetInt32(reader.GetOrdinal("Cliente"));
                turno.estado = Convert.ToChar(reader.GetValue(reader.GetOrdinal("Estado")));
                turno.agenda = reader.GetInt32(reader.GetOrdinal("Agenda"));
                turno.fechaCreacion = reader.GetDateTime(reader.GetOrdinal("FechaHoraCreacion"));
                turno.fechaTurno = reader.GetDateTime(reader.GetOrdinal("FechaHoraTurno"));
                turno.fechaEntrega = reader.GetDateTime(reader.GetOrdinal("FechaHoraEntrega"));
                turno.activo = reader.GetBoolean(reader.GetOrdinal("activo"));

                turnosHistoricos.Add(turno);
            }

            return turnosHistoricos;
        }

        public List<TurnoHistorico> GetChanges(BE.FiltroHistorico filtro)
        {
            var cnn = new SqlConnection(accesso.GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var query = $@"SELECT th.[Id]
                                 ,th.[Activo]
                                 ,th.[FechaHora]
                                 ,th.[Operacion]
                                 ,th.[Usuario]
                                 ,th.[IdTurno]
                                 ,th.[Cliente]
								 ,th.[Estado]
                                 ,th.[Agenda]
                                 ,th.[FechaHoraCreacion]
                                 ,th.[FechaHoraTurno]
                                 ,th.[FechaHoraEntrega]                                 
                                 ,e.[Id] as Estudio
                             FROM [dbo].[Turno_Historial] th
                             JOIN [dbo].[Agenda] a ON a.Id = th.Agenda
                             JOIN [dbo].[Estudio] e ON a.Estudio = e.Id";

            if (filtro.usuario != null)
            {
                query += $@" WHERE th.[Usuario] = '{filtro.usuario}'";
            }
            if (filtro.estudio != -10)
            {
                if (query.Contains("WHERE"))
                    query += $@" AND e.Id = '{filtro.estudio}'";
                else
                    query += $@" WHERE e.Id = '{filtro.estudio}'";
            }
            if (filtro.operacion != null)
            {
                if (query.Contains("WHERE"))
                    query += $@" AND th.[Operacion] = '{filtro.operacion}'";
                else
                    query += $@" WHERE th.[Operacion] = '{filtro.operacion}'";
            }
            if (filtro.fechaDesde != DateTime.MinValue && filtro.fechaHasta != DateTime.MaxValue)
            {
                if (query.Contains(" WHERE"))
                    query += $@" AND th.[FechaHora] >= '{filtro.fechaDesde}' and th.[FechaHora]  <= '{filtro.fechaHasta}'";
                else
                    query += $@" WHERE th.[FechaHora] >= '{filtro.fechaDesde}' and th.[FechaHora] <= '{filtro.fechaHasta}'";
            }


            cmd.CommandText = query;

            var reader = cmd.ExecuteReader();

            List<TurnoHistorico> turnoHistoricoList = new List<TurnoHistorico>();
            while (reader.Read())
            {
                TurnoHistorico turnoHistorico = new TurnoHistorico();
                //evento.Id = reader.GetInt32(reader.GetOrdinal("id"));
                //evento.IdUsuario = reader.GetInt32(reader.GetOrdinal("idUsuario"));
                turnoHistorico.Id = reader.GetInt32(reader.GetOrdinal("id"));
                turnoHistorico.activo = reader.GetBoolean(reader.GetOrdinal("Activo"));
                turnoHistorico.FechaHora = reader.GetDateTime(reader.GetOrdinal("fechaHora"));
                turnoHistorico.Operacion = reader.GetString(reader.GetOrdinal("operacion"));
                turnoHistorico.Usuario = reader.GetString(reader.GetOrdinal("usuario"));
                turnoHistorico.idTurno = reader.GetInt32(reader.GetOrdinal("idTurno"));
                turnoHistorico.client = reader.GetInt32(reader.GetOrdinal("cliente"));
                turnoHistorico.estado = Convert.ToChar(reader.GetValue(reader.GetOrdinal("Estado")));
                turnoHistorico.agenda = reader.GetInt32(reader.GetOrdinal("agenda"));
                turnoHistorico.fechaCreacion= reader.GetDateTime(reader.GetOrdinal("fechaHoraCreacion"));
                turnoHistorico.fechaTurno = reader.GetDateTime(reader.GetOrdinal("fechaHoraTurno"));
                turnoHistorico.fechaEntrega = reader.GetDateTime(reader.GetOrdinal("fechaHoraEntrega"));                

                turnoHistoricoList.Add(turnoHistorico);
            }

            return turnoHistoricoList;
        }

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

        public List<Turno> GetByEstudioSucursal(int estudio, int sucursal)
        {
            List<Turno> turnos = new List<Turno>();

            try
            {
                SqlParameter[] parameter = new SqlParameter[2];
                parameter[0] = new SqlParameter("@estudio", estudio);
                parameter[1] = new SqlParameter("@entidad", sucursal);

                DataTable dataTable = accesso.Read("TurnosGetByEstudioSucursal", parameter);

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

        public int Create(BE.Turno turno, BE.User user)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[7];
                parameters[0] = new SqlParameter("usuario", user.LoginName);
                parameters[1] = new SqlParameter("cliente", turno.client);
                parameters[2] = new SqlParameter("estado", turno.estado);
                parameters[3] = new SqlParameter("agenda", turno.agenda);
                parameters[4] = new SqlParameter("fechaHoraCreacion", turno.fechaCreacion);
                parameters[5] = new SqlParameter("fechaHoraTurno", turno.fechaTurno);
                parameters[6] = new SqlParameter("fechaHoraEntrega", turno.fechaEntrega);
                return accesso.Write("TurnoCrear", parameters);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Update(BE.Turno turno, BE.User user)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[8];
                parameters[0] = new SqlParameter("id", turno.Id);
                parameters[1] = new SqlParameter("usuario", user.LoginName);
                parameters[2] = new SqlParameter("cliente", turno.client);
                parameters[3] = new SqlParameter("estado", turno.estado);
                parameters[4] = new SqlParameter("agenda", turno.agenda);
                parameters[5] = new SqlParameter("fechaHoraCreacion", turno.fechaCreacion);
                parameters[6] = new SqlParameter("fechaHoraTurno", turno.fechaTurno);
                parameters[7] = new SqlParameter("fechaHoraEntrega", turno.fechaEntrega);

                return accesso.Write("TurnoActualizar", parameters);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Delete(BE.Turno turno,BE.User user) 
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("usuario", user.LoginName);
                parameters[1] = new SqlParameter("id", turno.Id);

                return accesso.Write("TurnoEliminar", parameters);
            }
            catch (Exception ex) { throw ex; }  
        }
    }
}
