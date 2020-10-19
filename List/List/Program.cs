using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringCollection = new List<string>();
            stringCollection.Add("matin");
            stringCollection.Add("midi");
            stringCollection.Add("soir");

            stringCollection.RemoveAt(0);

            stringCollection.Remove("soir");

            stringCollection[0] = "AM";

            int CollectionCount = stringCollection.Count;


            Console.WriteLine(CollectionCount);


        }
    }
}
