﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_Petpals.exception
{
    public class AdoptionException : Exception
    {
        public AdoptionException(string message) : base(message) { }
    }
}
