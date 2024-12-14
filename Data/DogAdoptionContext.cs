using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DogAdoption.Models;

namespace DogAdoption.Data
{
    public class DogAdoptionContext : DbContext
    {
        public DogAdoptionContext (DbContextOptions<DogAdoptionContext> options)
            : base(options)
        {
        }

        public DbSet<DogAdoption.Models.User> User { get; set; } = default!;
        public DbSet<DogAdoption.Models.Dog> Dog { get; set; } = default!;
        public DbSet<DogAdoption.Models.AdoptionApplication> AdoptionApplication { get; set; } = default!;
        public DbSet<DogAdoption.Models.AdoptionPosting> AdoptionPosting { get; set; } = default!;
        public DbSet<DogAdoption.Models.Messages> Messages { get; set; } = default!;
    }
}
