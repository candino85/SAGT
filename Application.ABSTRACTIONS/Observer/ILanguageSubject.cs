using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ABSTRACTIONS
{
    public interface ILanguageSubject
    {
        IList<ILanguageObserver> languageObservers { get; set; }
        void SubscribeObserver(ILanguageObserver LanguageObserver);
        void UnsubscribeObserver(ILanguageObserver LanguageObserver);
        void NotifyAllObservers(ILanguage language);
    }
}
