using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    class Person
    {
        public Guid PersonId { get; set; }
        public String PersonName { get; set; }
        public ICollection<SavingAccount> SavingAccounts { get; set; }
    }
    
}
