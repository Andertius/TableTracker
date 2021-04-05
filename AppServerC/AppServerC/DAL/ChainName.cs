using System;
using System.Collections.Generic;

#nullable disable

namespace AppServerC
{
    public partial class ChainName
    {
        public ChainName()
        {
            Places = new HashSet<Place>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Place> Places { get; set; }
    }
}
