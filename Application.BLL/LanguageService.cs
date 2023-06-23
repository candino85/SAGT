using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BE;
using Application.DLL;

namespace Application.BLL
{
    public class LanguageService
    {
        readonly LanguageRepository languageRepository;

        public LanguageService()
        {
            languageRepository = new LanguageRepository();
        }
        
        public List<Language> GetLanguages()
        {
            List<Language> languages = languageRepository.GetLanguagesList();
            return languages;
        }

        public Language GetLanguage(string name)
        {
            return languageRepository.GetLanguage(name);
        }

        public DataSet GetDataSet()
        {
            return languageRepository.GetDataSet();
        }

        public void CreateTranslation(string tag,string translate, string language)
        {
            languageRepository.createTranslation(tag, translate, GetLanguage(language));
        }

        public void UpdateTranslation(string tag, string translate, string language)
        {
            languageRepository.updateTranslation(tag, translate, GetLanguage(language));
        }

        public void CreateNewLanguage(string name) 
        {
            languageRepository.createLanguage(name);
        }
    }
}
