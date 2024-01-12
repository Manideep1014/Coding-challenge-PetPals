using Coding_Challenge_Petpals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_Petpals.DAO
{
    public interface IAdoptable
    {
         void Adopt(Pet pet, Participant participant);
    }
}
