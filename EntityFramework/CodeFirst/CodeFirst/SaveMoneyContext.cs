using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CodeFirst
{
    class SavingContext : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=Saving;Integrated Security=True");
        }
    }
}
