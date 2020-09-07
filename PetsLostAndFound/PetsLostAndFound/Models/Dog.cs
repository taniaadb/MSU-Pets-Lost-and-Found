using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    public class Dog : Animal
    {
        public Dog()
        {
            this.SubType = BaseType.Dog;
            this.Type = this.SubType.ToString();
        }
    }
}
