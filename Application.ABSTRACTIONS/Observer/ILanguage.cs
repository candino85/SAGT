using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ABSTRACTIONS
{
    public interface ILanguage : IEntity
    {
        string Name { get; set; }
        IList<ITranslate> Translates { get; set; }
        void AddTranslate(ITranslate translate);
        string SearchTranslate(string text);
    }
}
