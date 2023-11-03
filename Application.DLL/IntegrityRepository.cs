using Application.Services;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Application.DLL
{
    public class IntegrityRepository
    {
        readonly DBAccess access = new DBAccess();
        public void SetDV(string entity)
        {

            var cnn = new SqlConnection(access.GetConnectionString());
            var cnn2 = new SqlConnection(access.GetConnectionString());

            cnn.Open();
            cnn2.Open();

            var cmd = new SqlCommand();
            var cmd2 = new SqlCommand();

            cmd.Connection = cnn;
            cmd2.Connection = cnn2;

            var query = $@"select * from {entity}";
            cmd.CommandText = query;

            SqlDataReader reader = cmd.ExecuteReader();

            var resultDH = "";
            var resultDV = "";

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount - 1; i++)
                {
                    resultDH += reader[reader.GetName(i)];

                }

                resultDH = Encrypt.GetSHA256(resultDH);

                query = $"update {entity} set DVH = '{resultDH}' where Id = {reader[reader.GetName(0)]}";
                cmd2.CommandText = query;
                cmd2.ExecuteNonQuery();

                resultDV += resultDH;

                resultDH = "";
            }
            resultDV = Encrypt.GetSHA256(resultDV);

            query = $"update DVV set DVV = '{resultDV}' where tabla = '{entity}'";
            cmd2.CommandText = query;
            cmd2.ExecuteNonQuery();

            reader.Close();
            cmd.Dispose();
            cmd2.Dispose();
        }
        public Dictionary<string, string> CheckDV(string entity)
        {
            var DVs = new Dictionary<string, string>();

            var cnn = new SqlConnection(access.GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var query = $@"select * from {entity}";
            cmd.CommandText = query;

            SqlDataReader reader = cmd.ExecuteReader();

            var resultDH = "";
            var resultDV = "";

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount - 1; i++)
                {
                    resultDH += reader[reader.GetName(i)];
                }

                resultDH = Encrypt.GetSHA256(resultDH);
                DVs.Add(reader[reader.GetName(0)].ToString(), resultDH);
                resultDV += resultDH;
                resultDH = "";
            }

            resultDV = Encrypt.GetSHA256(resultDV);
            DVs.Add("DVV", resultDV);

            reader.Close();
            cmd.Dispose();

            return DVs;
        }
        private Dictionary<string, string> GetDV(string entity)
        {
            var DVs = new Dictionary<string, string>();

            var cnn = new SqlConnection(access.GetConnectionString());
            var cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;

            var query = $@"select Id,DVH from {entity}";
            cmd.CommandText = query;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DVs.Add(reader["Id"].ToString(), reader["DVH"].ToString());
            }

            reader.Close();

            query = $@"select DVV from DVV where tabla = '{entity.TrimStart().TrimEnd()}'";
            cmd.CommandText = query;

            DVs.Add("DVV", cmd.ExecuteScalar().ToString());

            cmd.Dispose();
            return DVs;
        }
        public Dictionary<string, string> CompareDVs(string entity)
        {
            Dictionary<string, string> dvdb = GetDV(entity);
            Dictionary<string, string> dvcal = CheckDV(entity);
            Dictionary<string, string> dverror = new Dictionary<string, string>();

            if (dvdb["DVV"] != dvcal["DVV"])
            {
                dverror.Add("tabla",entity);

                foreach (KeyValuePair<string, string> row in dvdb)
                {
                    if (row.Value != dvcal[row.Key])
                    {
                        dverror.Add(row.Key, row.Value);
                    }
                }
            }
            return dverror;
        }
    }
}
