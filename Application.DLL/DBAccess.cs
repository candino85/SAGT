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
        SqlConnection CN = new SqlConnection();        

        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "NB-CRISTIAN\\SQLEXPRESS2019";
            cs.InitialCatalog = "Campo";
            return cs.ConnectionString;
        }

        void Conectar()
        {
            if (CN.State.ToString() == "Closed")
            {
                CN.ConnectionString = GetConnectionString();
                CN.Open();
            }
            else
                Desconectar();
            
        }

        void Desconectar()
        {
            CN.Close();
            CN.Dispose();
        }

        public int Escribir(string sp, SqlParameter[] parametros)
        {
            Conectar();
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
            Desconectar();
            return fa;
        }

        public DataTable Leer(string sp, SqlParameter[] parametros)
        {
            Conectar();
            DataTable dataTable = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand();
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.CommandText = sp;

            if (parametros != null)
                dataAdapter.SelectCommand.Parameters.AddRange(parametros);

            dataAdapter.SelectCommand.Connection = CN;
            dataAdapter.Fill(dataTable);

            Desconectar();
            return dataTable;
        }

        //public IDataReader Leer(string query, SqlParameter sqlParameters[])
        //{
        //    //SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
        //    //cs.InitialCatalog = "Campo";
        //    //cs.DataSource = "NB-CRISTIAN\\SQLEXPRESS2019";
        //    //cs.IntegratedSecurity = true;

        //    //SqlConnection sql = new SqlConnection();
        //    sql.ConnectionString = GetConnectionString();
        //    IDataReader reader = null;
        //    try
        //    {
        //        Conectar();
        //        //sql.Open();
        //        SqlCommand CMD = new SqlCommand();
        //        CMD.Connection = CN;
        //        //CMD.CommandText = "select loginname from users where id = @id";
        //        CMD.CommandText = query;
        //        //CMD.Parameters.AddWithValue("id", id);
        //        foreach(SqlParameter p in sqlParameters)
        //        {
        //            CMD.Parameters = p;
        //        }


        //        reader = CMD.ExecuteReader();

        //        if (!reader.Read()) throw new Exception("No se encuentra el usuario");

        //        return reader;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        reader.Close();
        //        sql.Close();
        //    }
        //}

    }
}
