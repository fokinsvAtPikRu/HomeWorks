﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public interface IFlyable
    {
        public int MaxAltitude { get; }
        public string Fly();
    }
}
