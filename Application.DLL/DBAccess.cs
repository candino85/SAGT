using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Application.DLL
{
    public class DBAccess
    {
        readonly SqlConnection CN = new SqlConnection();        

        public string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "NB-CRISTIAN\\SQLEXPRESS2019";
            cs.InitialCatalog = "Campo";
            return cs.ConnectionString;
        }

        void Connect()
        {
            if (CN.State.ToString() == "Closed")
            {
                CN.ConnectionString = GetConnectionString();
                CN.Open();
            }
            else
                Disconnect();            
        }

        void Disconnect()
        {
            CN.Close();
            CN.Dispose();
        }

        public int Write(string sp, SqlParameter[] parametros)
        {
            Connect();
            int fa = 0;

            SqlCommand CMD = new SqlCommand();
            SqlTransaction TR;

            TR = CN.BeginTransaction();

            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = sp;
            CMD.Connection = CN;
            CMD.Parameters.AddRange(parametros);

            try
            {                
                CMD.Transaction = TR;
                fa = CMD.ExecuteNonQuery();
                TR.Commit();
                fa = 1;
            }
            catch (Exception ex)
            {
                TR.Rollback($"La transacción falló \n{ex.ToString()}");               
            }
            Disconnect();
            return fa;
        }

        public int WriteCommand(SqlCommand cm)
        {
            Connect();

            SqlTransaction TR;
            int id = 0;
            TR = CN.BeginTransaction();

            cm.CommandType = CommandType.Text;
            cm.CommandText = cm.CommandText;          
            cm.Connection = CN;

            try
            {
                cm.Transaction = TR;
                id = (int)cm.ExecuteScalar();
                TR.Commit();
            }
            catch (Exception ex)
            {
                TR.Rollback($"La transacción falló \n{ex.ToString()}");
            }
            
            Disconnect();
            return id;
        }

        public int DeleteCommand(SqlCommand cm)
        {
            Connect();

            SqlTransaction TR;
            int ok = 0;
            TR = CN.BeginTransaction();

            cm.CommandType = CommandType.Text;
            cm.CommandText = cm.CommandText;
            cm.Connection = CN;

            try
            {
                cm.Transaction = TR;
                cm.ExecuteNonQuery();
                TR.Commit();
                ok = 1;
            }
            catch (Exception ex)
            {
                TR.Rollback($"La transacción falló \n{ex.ToString()}");
            }
            Disconnect();
            return ok;
        }

        public DataTable Read(string sp, SqlParameter[] parametros)
        {
            Connect();
            DataTable dataTable = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand();
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.CommandText = sp;

            if (parametros != null)
                dataAdapter.SelectCommand.Parameters.AddRange(parametros);

            dataAdapter.SelectCommand.Connection = CN;
            dataAdapter.Fill(dataTable);

            Disconnect();
            return dataTable;
        }

        public DataTable Read(SqlCommand cmd)
        {
            Connect();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.SelectCommand = new SqlCommand();
            dataAdapter.SelectCommand.CommandType = CommandType.Text;
            dataAdapter.SelectCommand.CommandText = cmd.CommandText;

            dataAdapter.SelectCommand.Connection = CN;
            dataAdapter.Fill(dataTable);

            Disconnect();
            return dataTable;
        }
    }
}
