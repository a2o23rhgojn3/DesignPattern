﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface IPrint
    {
        void PrintWeak();
        void PrintStrong();
    }
}
