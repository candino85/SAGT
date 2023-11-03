using System.Collections.Generic;

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
