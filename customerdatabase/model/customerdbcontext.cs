using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customerdatabase.model
{
    public class customerdbcontext : DbContext
    {
        public customerdbcontext(DbContextOptions<customerdbcontext> options) : base(options) { }
        public customerdbcontext()
        {

        }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        public DbSet<Customer_Info> Customers { get; set; }
        public DbSet<Order_Info> orders { get; set; }

    }

}
