using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ABSTRACTIONS
{
    public interface IUser
    {
        Guid Guid { get; set; }
        DateTime CreationDate { get; set; }
    }
}
