﻿using Microsoft.EntityFrameworkCore;
using ProductAccDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccInfra.Common
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<TestClean> TestClean { get; set; }
    }
}
