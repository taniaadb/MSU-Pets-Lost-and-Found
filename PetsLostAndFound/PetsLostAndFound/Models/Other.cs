using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    public class Other : Animal
    {
        public Other()
        {
            this.Type = BaseType.Other;
        }
    }
}
