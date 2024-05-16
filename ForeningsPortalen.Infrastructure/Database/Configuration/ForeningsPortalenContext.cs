using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Database.Configuration
{
    public class ForeningsPortalenContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Union> Unions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        //public DbSet<> Users { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<User> Users { get; set; }


    }
}
