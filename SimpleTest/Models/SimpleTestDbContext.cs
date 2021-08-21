using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTest.Models
{
    public class SimpleTestDbContext : DbContext 
    {
        public DbSet<UserInformation> UserInformation { get; set; }

        public SimpleTestDbContext(DbContextOptions<SimpleTestDbContext> options):base(options)
        {

        }
    }
}
