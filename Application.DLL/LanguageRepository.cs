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
    public class LanguageRepository
    {
        readonly DBAccess access = new DBAccess();

        public List<Language> GetLanguagesList()
        {
            var cnn = new SqlConnection(access.GetConnectionString());

            try
            {
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                var query = $@"select id,idioma,[default] from idioma;";
                cmd.CommandText = query;

                var reader = cmd.ExecuteReader();

                List<Language> languages = new List<Language>();

                while (reader.Read())
                {
                    Language language = new Language();
                    language.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    language.Name = reader.GetString(reader.GetOrdinal("idioma"));
                    language.Default = reader.GetBoolean(reader.GetOrdinal("default"));
                    languages.Add(language);
                }

                reader.Close();
                cnn.Close();

                return languages;
            }
            catch(Exception ex)
            {
                cnn.Close();
                throw new Exception(ex.Message);
            }
        }

        public Language GetLanguage(string name)
        {
            var cnn = new SqlConnection(access.GetConnectionString());

            try
            {
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                var query = $@"select * from idioma i where i.idioma = '{name}'";

                cmd.CommandText = query;

                SqlDataReader reader = cmd.ExecuteReader();

                Language language = new Language();
                while (reader.Read())
                {
                    language.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    language.Name = reader.GetString(reader.GetOrdinal("idioma"));
                }
                reader.Close();
                cnn.Close();

                language.Translations = GetTranslations(language);

                return language;
            }
            catch (Exception ex)
            {
                cnn.Close();
                throw new Exception(ex.Message);
            }
        }

        public Language GetLanguage(int id)
        {
            var cnn = new SqlConnection(access.GetConnectionString());

            try
            {
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                var query = $@"select * from idioma i where i.id = '{id}'";

                cmd.CommandText = query;

                SqlDataReader reader = cmd.ExecuteReader();

                Language language = new Language();
                while (reader.Read())
                {
                    language.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    language.Name = reader.GetString(reader.GetOrdinal("idioma"));
                }
                reader.Close();
                cnn.Close();

                language.Translations = GetTranslations(language);

                return language;
            }
            catch (Exception ex)
            {
                cnn.Close();
                throw new Exception(ex.Message);
            }
        }

        public List<ITranslation> GetTranslations (Language language)
        {
            var cnn = new SqlConnection(access.GetConnectionString());
            
            try
            {
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                var query = $@"select * from translation where ididioma = {language.Id};";

                cmd.CommandText = query;

                SqlDataReader reader = cmd.ExecuteReader();

                List<ITranslation> listTranslations = new List<ITranslation>();

                while (reader.Read())
                {
                    Translation translation = new Translation();
                    translation.Translate = reader.GetString(reader.GetOrdinal("traduccion"));
                    translation.Key = reader.GetString(reader.GetOrdinal("Tag"));
                    listTranslations.Add(translation);
                }
                reader.Close(); 
                cnn.Close();
                
                return listTranslations;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet GetDataSet()
        {
            List<Language> languages = GetLanguagesList();

            string languagesString = string.Join(",", (languages.Select(language => language.Name).ToArray()));

            var cnn = new SqlConnection(access.GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var query = $@"select * from ( select i.Idioma, t.tag as Palabra,t.traduccion as translation
				                             from idioma i 
                                             inner join translation t on i.id = t.ididioma
				                            ) asd
                             pivot( max  (translation) for Idioma in ( {languagesString}) ) as p";

            cmd.CommandText = query;

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand= cmd;

            var dataSet = new DataSet();

            adapter.Fill(dataSet, "myTable");

            cnn.Close();

            return dataSet;
        }

        public void createTranslation(string tag, string translation,Language language)
        {
            var cnn = new SqlConnection(access.GetConnectionString());

            try
            {
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"
                                    INSERT INTO [dbo].[translation]
                                               ([ididioma]
                                               ,[tag]
                                               ,[traduccion])
                                         VALUES
                                               (@languageId
                                               ,@tag
                                               ,@traduccion)";
                cmd.Parameters.Add(new SqlParameter("tag", tag));
                cmd.Parameters.Add(new SqlParameter("traduccion", translation));
                cmd.Parameters.Add(new SqlParameter("languageId", language.Id));

                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updateTranslation(string tag, string translation, Language language)
        {
            var cnn = new SqlConnection(access.GetConnectionString());

            try
            {
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"UPDATE [dbo].[translation]
                                     SET [traduccion] = @traduccion
                                     WHERE [tag] = @tag and [ididioma] = @languageId";
                cmd.Parameters.Add(new SqlParameter("tag", tag));
                cmd.Parameters.Add(new SqlParameter("traduccion", translation));
                cmd.Parameters.Add(new SqlParameter("languageId", language.Id));

                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void createLanguage(string name)
        {
            var cnn = new SqlConnection(access.GetConnectionString());

            try
            {
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"insert into idioma (idioma) values (@idioma)";
                cmd.Parameters.Add(new SqlParameter("idioma", name));

                cmd.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
