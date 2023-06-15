﻿using Core.Entities.Concrete;
using Entities.Concrate;
using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-9PMBFOV;Initial Catalog=Northwind;Integrated Security=True");
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<OperationClaim>? OperationClaims { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<UserOperationClaim>? UserOperationClaims { get; set; }


    }
}
