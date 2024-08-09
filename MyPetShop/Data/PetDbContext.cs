using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyThirdASPNET.Models;

namespace MyPetShop.Data
{
    public class PetDbContext : DbContext
    {
        public PetDbContext (DbContextOptions<PetDbContext> options)
            : base(options)
        {
        }

        public DbSet<MyThirdASPNET.Models.Dog> Dog { get; set; } = default!;
        public DbSet<MyThirdASPNET.Models.Cat> Cat { get; set; } = default!;
    }
}
