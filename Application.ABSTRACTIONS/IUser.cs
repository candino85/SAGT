﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ABSTRACTIONS
{
    public interface IUser : IPerson
    {
        string LoginName { get; set; }
        string Password { get; set; }
    }
}
