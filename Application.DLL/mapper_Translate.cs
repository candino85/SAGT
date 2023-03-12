using Application.ABSTRACTIONS;
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
    public class mapper_Translate
    {
        readonly DBAccess accesso = new DBAccess();
        //public List<Translation> GetTranslates(int language, List<BE.Word> words)
        //{
        //    List<BE.Translation> listaTranslate = new List<BE.Translation>();
        //    SqlParameter[] parameter = new SqlParameter[1];
        //    parameter[0] = new SqlParameter("@ididioma", language);

        //    DataTable dataTable = accesso.Read("TraduccionGet", parameter);

        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        BE.Translation translate = new Translation
        //        {
        //            Id = int.Parse(row["id"].ToString()),
        //            Word = words.FirstOrDefault(x => x.Id == int.Parse(row["idpalabra"].ToString())),
        //            Word = row["palabratraducida"].ToString(),
        //        };

        //        listaTranslate.Add(translate);
        //    }
        //    return listaTranslate;
        //}
    }
}
