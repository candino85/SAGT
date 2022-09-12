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
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

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
            string translate = Translates.FirstOrDefault(x => x.Word.Text == text).TranslatedWord;
            if (!string.IsNullOrEmpty(translate))
            {
                return translate;
            }
            else
                return text;
        }
    }
}
