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
            this.SubType = BaseType.Other;
            this.Type = this.SubType.ToString();
        }
    }
}
