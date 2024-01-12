using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_Petpals.exception
{
    public class InvalidPetAgeException: Exception
    {
        public InvalidPetAgeException(string message) : base(message) { }
    }
}
