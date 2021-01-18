using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace async_await
{
    class Program
    {
        public static async Task<Int32> Main(string[] args)
        {
            Random random = new Random();
            Int32 task1 = random.Next(0, 3000);
            Int32 task2 = random.Next(2000, 5000);
            await Task.Delay(task1);
            await Task.Delay(task2);
            Console.WriteLine("Délai tâche 1 :" + task1);
            Console.WriteLine("Délai tâche 2 :" + task2);
            return 0;
        }
    }
}
