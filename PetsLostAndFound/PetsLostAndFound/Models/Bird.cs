using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    public class Bird : Animal
    {
        public Bird()
        {
            this.SubType = BaseType.Bird;
            this.Type = this.SubType.ToString();
        }
    }
}
