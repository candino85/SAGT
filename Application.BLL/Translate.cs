using Application.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BLL
{
    public class Translate
    {
        readonly mapper_Translate _mapper;
        public List<BE.Translate> Listar(BE.Language language, List<BE.Word> words)
        {
            List<BE.Translate> translates = _mapper.GetTranslates(language.Id, words);

            //foreach (BE.Translate translate in listaTranslates)
            //{
            //    language.AddTranslate(translate);
            //}
            return translates;
        }
    }
}
