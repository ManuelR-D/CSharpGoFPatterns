﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Observer.interfaces
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
