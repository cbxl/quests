using System;
using System.Collections.Generic;


namespace LinQ
{
    public class Species
    {
        public Guid SpeciesId { get; set; }
        public String SpeciesName { get; set; }

        public ICollection<Animal> Animal { get; set; }
    }
}
