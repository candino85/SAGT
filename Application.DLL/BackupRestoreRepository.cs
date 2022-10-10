using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DLL
{
    public class BackupRestoreRepository
    {
        readonly DBAccess dbAccess = new DBAccess();
        public string BackupDatabase(string path)
        {
            SqlConnection conn = new SqlConnection(dbAccess.GetConnectionString());
            conn.Open();

            try 
            {                
                string query = $"BACKUP DATABASE {conn.Database} TO DISK = '{path}\\{conn.Database}_{DateTime.Now.ToString("yyyyMMdd-hhmmss")}.bak'";
                
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                
                string msg = "Backup generado correctamente";
                return msg;
                conn.Close();
            }
            catch (Exception ex)
            {                
                conn.Close();
                return ex.ToString();
            }
        }

        public string RestoreDatabase(string path)
        {
            SqlConnection conn = new SqlConnection(dbAccess.GetConnectionString());
            conn.Open();

            try
            {                
                string query = $"USE[master] ALTER DATABASE Campo SET Single_User WITH Rollback Immediate;  RESTORE DATABASE Campo FROM DISK = N'{path}' WITH REPLACE; ALTER DATABASE Campo SET Multi_User";

                SqlCommand comm = new SqlCommand(query,conn);
                comm.ExecuteNonQuery();

                string msg = "Backup restaurado correctamente";
                return msg;

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.ToString();
            }
        }

    }
}
