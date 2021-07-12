using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ABSTRACTIONS
{
    public interface ISubject
    {
        IList<IObserver> observers { get; set; }
        void SubscribeObserver(IObserver observer);
        void UnsubscribeObserver(IObserver observer);
        void NotifyAllObservers(ILanguage language);
    }
}
