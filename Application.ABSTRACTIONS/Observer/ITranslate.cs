using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ABSTRACTIONS
{
    public interface ITranslate : IEntity
    {
        string TranslatedWord { get; set; }
        IWord Word { get; set; }
    }
}
