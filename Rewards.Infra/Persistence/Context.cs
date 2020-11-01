﻿using Microsoft.EntityFrameworkCore;
using Rewards.Core.Entities;
using Rewards.Infra.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Infra.Persistence
{
    public class Context:DbContext
    {
        public DbSet<User> User { get; set; }

        public Context(DbContextOptions<Context> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
