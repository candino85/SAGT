using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Translate : Entity, ITranslate
    {
        public string TranslatedWord { get ; set ; }
        public IWord Word { get ; set ; }
    }
}
