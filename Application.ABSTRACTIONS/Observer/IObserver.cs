using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.ABSTRACTIONS
{
    public interface IObserver
    {
        void NotifyObserver(ILanguage languageObserver);
    }
}