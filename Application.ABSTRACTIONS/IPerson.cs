using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ABSTRACTIONS
{
    public interface IPerson
    {
        string Name { get; set; }
        string Lastname { get; set; }
        string DNI { get; set; }
        string Address { get; set; }
        DateTime CreationDate { get; set; }
        bool Active { get; set; }
        string FullName { get; }
    }
}
