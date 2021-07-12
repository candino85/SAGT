using Application.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DLL
{
    public class mapper_Word
    {
        readonly DBAccess accesso = new DBAccess();
        public List<BE.Word> GetWords()
        {
            List<BE.Word> words = new List<BE.Word>();
            DataTable dataTable = accesso.Leer("PalabraListar", null);

            foreach (DataRow row in dataTable.Rows)
            {
                BE.Word word = new Word
                {
                    Id = int.Parse(row["idpalabra"].ToString()),
                    Text = row["palabra"].ToString(),
                };

                words.Add(word);
            }
            return words;
        }
    }
}
