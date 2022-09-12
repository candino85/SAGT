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
    public class mapper_Language
    {
        readonly DBAccess accesso = new DBAccess();
        public List<BE.Language> Listar()
        {
            List<BE.Language> listaLanguage= new List<BE.Language>();
            DataTable dataTable = accesso.Read("IdiomaListar", null);

            foreach (DataRow row in dataTable.Rows)
            {
                BE.Language language = new Language
                {
                    Id = int.Parse(row["id"].ToString()),
                    Name = row["idioma"].ToString(),
                };

                listaLanguage.Add(language);
            }

            return listaLanguage;
        }

        /// <summary>
        /// Recupero el ID del idioma para poder traer todas las traducciones del mismo
        /// </summary>
        /// <param name="nombre">Es el string del nombre del idioma. TODO: debería enviar directamente el ID desde a interfaz</param>
        /// <returns>Devuelve un objeto Language que contendrá el ID y el nombre del idioma seleccionado para una posterior búsqueda de las traducciones</returns>
        public BE.Language GetLanguage(string nombre)
        {
            BE.Language language = new Language();

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@idioma", nombre);
            DataTable dataTable = accesso.Read("IdiomaGet", parameter);

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    language.Id = int.Parse(row["id"].ToString());
                    language.Name = row["idioma"].ToString();
                }
            }
            else
                throw new Exception("Idioma invalido");            

            return language;
        }

        public BE.Language GetLanguage(int idLanguage)
        {
            BE.Language language = new Language();

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", idLanguage);
            DataTable dataTable = accesso.Read("IdiomaGetById", parameter);

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    language.Id = int.Parse(row["id"].ToString());
                    language.Name = row["idioma"].ToString();
                }
            }
            else
                throw new Exception("Idioma invalido");
            return language;
        }
    }
}
