﻿using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Database.Configuration
{
    public class ForeningsPortalenContext : DbContext
    {
        public ForeningsPortalenContext(DbContextOptions<ForeningsPortalenContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Union> Unions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new BmiTypeConfiguration());
        }

        //public DbSet<> Users { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<User> Users { get; set; }



    }
}
