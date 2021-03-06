﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetsLostAndFound.Models;

namespace PetsLostAndFound.Data
{
    public class PetsLostAndFoundContext : DbContext
    {
        public PetsLostAndFoundContext(DbContextOptions<PetsLostAndFoundContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animal { get; set; }
    }
}
