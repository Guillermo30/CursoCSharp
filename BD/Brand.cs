using System;
using System.Collections.Generic;

#nullable disable

namespace BD
{
    public partial class Brand
    {
        public Brand()
        {
            Beers = new HashSet<Beer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
