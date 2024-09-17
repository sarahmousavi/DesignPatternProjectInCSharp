﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //Interface for Observer
    public interface IObserver
    {
        void Update(string message);
    }
}