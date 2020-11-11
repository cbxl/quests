using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace CodeFirst
{
    class Program
    {
        static void Main()
        {


            using (var context = new SavingContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var person = new Person
                {
                    PersonName = "Richard"
                };

                person.SavingAccounts = new List<SavingAccount>
                {
                    new SavingAccount {Rate = 0.05, Capital = 2000000, Frequence = 1},
                    new SavingAccount {Rate = 0.15, Capital = 250000, Frequence = 12},
                    new SavingAccount {Rate = 0.02, Capital = 10000000, Frequence = 12},
                };


                context.Add(person);
                context.SaveChanges();

                SavingCalculator savingCalculator = new SavingCalculator();
                DateTime beginDate = new DateTime(2017, 1, 01);
                DateTime endDate = new DateTime (2020, 1, 01);
                savingCalculator.CalculatetotalSaved(beginDate, endDate, person.SavingAccounts);
                
            }

            
        }
    }
}
