using Application.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BLL
{
    public class Word
    {
        readonly mapper_Word _mapper = new mapper_Word();
        public List<BE.Word> GetWords()
        {
            List<BE.Word> listaWords = _mapper.GetWords();
            return listaWords;
        }
    }
}
