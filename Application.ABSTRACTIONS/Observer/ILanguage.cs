using System.Collections.Generic;

namespace Application.ABSTRACTIONS
{
    public interface ILanguage
    {
        string Name { get; set; }

        bool Default { get; set; }

        List<ITranslation> Translations { get; set; }
    }
}
