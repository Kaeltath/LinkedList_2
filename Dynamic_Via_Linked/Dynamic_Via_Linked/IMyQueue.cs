﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Via_Linked
{
    interface IMyQueue<T>
    {
        void Enqueue(T ElementToEnqueue);
        T Dequeue();

    }
}
