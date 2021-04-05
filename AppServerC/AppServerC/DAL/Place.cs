using System;
using System.Collections.Generic;

#nullable disable

namespace AppServerC
{
    public partial class Place
    {
        public Place()
        {
            Favourites = new HashSet<Favourite>();
            Histories = new HashSet<History>();
            PlaceSchemes = new HashSet<PlaceScheme>();
        }

        public int Id { get; set; }
        public int? PlaceId { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public int? PriceRange { get; set; }
        public string PlaceType { get; set; }
        public string Cuisine { get; set; }

        public virtual ChainName PlaceNavigation { get; set; }
        public virtual ICollection<Favourite> Favourites { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<PlaceScheme> PlaceSchemes { get; set; }
    }
}
