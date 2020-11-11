using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    class SavingCalculator
    {
        public void CalculatetotalSaved (DateTime beginDate, DateTime endDate, ICollection<SavingAccount> SavingAccounts)
        {
            Double numberOfMonth = DateAndTime.DateDiff(DateInterval.Month, beginDate, endDate);
            Double totalSaving = 0;

            foreach (SavingAccount savingAct in SavingAccounts)
            {
                if (savingAct.Frequence == 1)
                {
                    Double savingPerAccount = (savingAct.Capital * Math.Pow((1 + savingAct.Rate), numberOfMonth)) - savingAct.Capital;
                    totalSaving = totalSaving + savingPerAccount;
                    Console.WriteLine("Total Saving of monthly account during selected period : " + Math.Round(totalSaving, 2));
                }
                
                else if (savingAct.Frequence == 12)
                {
                    Double savingPerAccount = (savingAct.Capital * Math.Pow((1 + savingAct.Rate), (numberOfMonth / 12))) - savingAct.Capital;
                    totalSaving = totalSaving + savingPerAccount;
                    Console.WriteLine("Total Saving of yearly account during selected period : " + Math.Round(totalSaving, 2));
                }
            }
            Console.WriteLine("Total Saving of all accounts during selected period : " + Math.Round(totalSaving, 2));
        }
        

    }

}
