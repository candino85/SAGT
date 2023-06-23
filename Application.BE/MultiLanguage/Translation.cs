using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Translation : ITranslation
    {
        public string Key { get ; set ; }
        public string Translate { get ; set ; }
    }
}
