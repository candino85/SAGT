using Application.ABSTRACTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BE
{
    public class Word : Entity, IWord
    {
        public string Text { get ; set ; }
    }
}
