using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ABSTRACTIONS;
using Application.BE;
using Application.DLL;

namespace Application.BLL
{
    public class Language
    {
        readonly mapper_Language _mapperLanguage;
        readonly mapper_Word _mapper_Word;
        readonly mapper_Translate _mapperTranslate;

        public Language()
        {
            _mapperLanguage = new mapper_Language();
            _mapper_Word = new mapper_Word();
            _mapperTranslate = new mapper_Translate();
        }
        
        public List<BE.Language> Listar()
        {
            List<BE.Language> listaLanguages = _mapperLanguage.Listar();
            return listaLanguages;
        }

        /// <summary>
        /// Traigo el idioma seleccionado junto con las palabras a traducir y las traducciones para ese idioma
        /// </summary>
        /// <param name="nombre">Nombre de idioma a cambiar</param>
        /// <returns>Devuelve un lenguaje con sus respectivas traducciones</returns>
        public BE.Language GetLanguage(string nombre)
        {
            BE.Language language = _mapperLanguage.GetLanguage(nombre);
            List<BE.Word> words = _mapper_Word.GetWords();
            language.Translates = _mapperTranslate.GetTranslates(language.Id, words).ToList<ITranslate>();

            return language;
        }
    }
}
