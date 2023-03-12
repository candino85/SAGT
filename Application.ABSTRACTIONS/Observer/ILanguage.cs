using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ABSTRACTIONS
{
    public interface ILanguage 
    {
        string Name { get; set; }

        bool Default { get; set; }

        List<ITranslation> Translations { get; set; }
    }
}
