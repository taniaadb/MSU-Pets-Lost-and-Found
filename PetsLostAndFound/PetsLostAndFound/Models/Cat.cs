﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    public class Cat : Animal
    {
        public Cat()
        {
            this.Type = BaseType.Cat;
        }
    }
}
