using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LinQ
{
    public class Animal
    {
        public Guid AnimalId { get; set; }
        public String AnimalName { get; set; }

        public Int32 NumberOfIdentified { get; set; }

        public Species Species { get; set; }
        
    }
}
