using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    public class Cat : Animal
    {
        public Cat()
        {
            this.SubType = BaseType.Cat;
            this.Type = this.SubType.ToString();
        }
    }
}
