using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.ZooAnimals;
using WebApplication1.Data.zookeeper;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplication1.Data.ZooAnimals.animals> animals { get; set; }
        public DbSet<WebApplication1.Data.zookeeper.zkeeper> zkeeper { get; set; }
    }
}
