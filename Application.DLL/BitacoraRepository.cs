using Application.BE;
using Application.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Application.DLL
{
    public class BitacoraRepository
    {
        readonly DBAccess accesso = new DBAccess();

        public List<Bitacora> GetAllEvents()
        {
            var cnn = new SqlConnection(accesso.GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var query = $@"SELECT bita.[Id]
                                 ,bita.[IdUsuario]
								 ,usu.[LoginName]
                                 ,bita.[FechaHora]
                                 ,bita.[Modulo]
                                 ,bita.[Operacion]
                                 ,bita.[Criticidad]
								 ,bita.[Mensaje]
                             FROM [dbo].[Bitacora] bita
							 LEFT JOIN dbo.Usuarios usu ON usu.id = bita.IdUsuario";

            cmd.CommandText = query;

            var reader = cmd.ExecuteReader();

            List<Bitacora> bitacoraList = new List<Bitacora>();
            while (reader.Read())
            {
                Bitacora evento = new Bitacora();
                //evento.Id = reader.GetInt32(reader.GetOrdinal("id"));
                //evento.IdUsuario = reader.GetInt32(reader.GetOrdinal("idUsuario"));
                evento.LoginName = reader["loginname"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("loginname")) : "";
                evento.FechaHora = reader.GetDateTime(reader.GetOrdinal("fechaHora"));
                evento.Modulo = reader.GetString(reader.GetOrdinal("modulo"));
                evento.Operacion = reader.GetString(reader.GetOrdinal("operacion"));
                evento.Criticidad = reader.GetInt32(reader.GetOrdinal("criticidad"));
                evento.Mensaje = reader.GetString(reader.GetOrdinal("mensaje"));

                bitacoraList.Add(evento);
            }

            return bitacoraList;
        }

        public List<Bitacora> GetEvents(BE.Filtro filtro)
        {
            var cnn = new SqlConnection(accesso.GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var query = $@"SELECT bita.[IdUsuario]
                                 ,usu.[LoginName]
                                 ,bita.[FechaHora]
                                 ,bita.[Modulo]
                                 ,bita.[Operacion]
                                 ,bita.[Criticidad]
                                 ,bita.[Mensaje]
                             FROM [dbo].[Bitacora] bita
							 LEFT JOIN dbo.Usuarios usu ON usu.id = bita.IdUsuario";

            if (filtro.IdUsuario != -10)
            {
                query += $@" WHERE bita.[IdUsuario] = {filtro.IdUsuario}";
            }
            if (filtro.Modulo != null)
            {
                if (query.Contains("WHERE"))
                    query += $@" AND bita.[Modulo] = '{filtro.Modulo}'";
                else
                    query += $@" WHERE bita.[Modulo] = '{filtro.Modulo}'";
            }
            if (filtro.Criticidad != -10)
            {
                if (query.Contains("WHERE"))
                    query += $@" AND bita.[Criticidad] = {filtro.Criticidad}";
                else
                    query += $@" WHERE bita.[Criticidad] = {filtro.Criticidad}";
            }
            if (filtro.Operacion != null)
            {
                if (query.Contains("WHERE"))
                    query += $@" AND bita.[Operacion] = '{filtro.Operacion}'";
                else
                    query += $@" WHERE bita.[Operacion] = '{filtro.Operacion}'";
            }
            if (filtro.FechaHoraDesde != DateTime.MinValue && filtro.FechaHoraHasta != DateTime.MaxValue)
            {
                if (query.Contains(" WHERE"))
                    query += $@" AND bita.[FechaHora] >= '{filtro.FechaHoraDesde}' and bita.[FechaHora] <= '{filtro.FechaHoraHasta}'";
                else
                    query += $@" WHERE bita.[FechaHora] >= '{filtro.FechaHoraDesde}' and bita.[FechaHora] <= '{filtro.FechaHoraHasta}'";
            }

            cmd.CommandText = query;

            var reader = cmd.ExecuteReader();

            List<Bitacora> bitacoraList = new List<Bitacora>();
            while (reader.Read())
            {
                Bitacora evento = new Bitacora();
                //evento.Id = reader.GetInt32(reader.GetOrdinal("id"));
                //evento.IdUsuario = reader.GetInt32(reader.GetOrdinal("idUsuario"));
                evento.LoginName = reader["loginname"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("loginname")) : "";
                evento.FechaHora = reader.GetDateTime(reader.GetOrdinal("fechaHora"));
                evento.Modulo = reader.GetString(reader.GetOrdinal("modulo"));
                evento.Operacion = reader.GetString(reader.GetOrdinal("operacion"));
                evento.Criticidad = reader.GetInt32(reader.GetOrdinal("criticidad"));
                evento.Mensaje = reader.GetString(reader.GetOrdinal("mensaje"));

                bitacoraList.Add(evento);
            }

            return bitacoraList;
        }

        public void LogEvent(int idUsuario, string modulo, string operacion, int criticidad, string msj)
        {
            var cnn = new SqlConnection(accesso.GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var query = $@"INSERT INTO [dbo].[Bitacora]
                            ([IdUsuario]
                            ,[FechaHora]
                            ,[Modulo]
                            ,[Operacion]
                            ,[Criticidad]
                            ,[Mensaje])
                           VALUES
                            ({idUsuario},
                             '{DateTime.Now}',
                             '{modulo}',
                             '{operacion}',
                             {criticidad},
                             '{msj}')";

            cmd.CommandText = query;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Sucedió un error en DAL", ex);
            }

        }

    }
}
