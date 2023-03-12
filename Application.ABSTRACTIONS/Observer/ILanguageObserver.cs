using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.ABSTRACTIONS
{
    public interface ILanguageObserver
    {
        void updateLanguage(ILanguage language);
    }
}