﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreDbSample.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreDbSample.Data
{
    public class UserContext : DbContext
    {
      
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
           
        }

    }
}
