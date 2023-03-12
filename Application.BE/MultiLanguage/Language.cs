using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Language : ILanguage, IEntity
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

        private bool _default;
        public bool Default
        {
            get { return _default; }
            set { _default = value; }
        }

        public List<ITranslation> Translations { get ; set ; }
    }
}
