using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnet_udemy.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters => Set<Character>(); 

        public DbSet<User> Users => Set<User>(); 

        public DbSet<Weapon> Weapons => Set<Weapon>(); 
    }
}