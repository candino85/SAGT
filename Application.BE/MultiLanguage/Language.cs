using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Language : IEntity, ILanguage
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public IList<ITranslate> Translates { get ; set ; }

        public Language()
        {
            Translates = new List<ITranslate>();
        }
        public void AddTranslate(ITranslate translate)
        {
            Translates.Add(translate);
        }

        public string SearchTranslate(string text)
        {
            return Translates.FirstOrDefault(x => x.Word.Text == text).TranslatedWord;
        }
    }
}
