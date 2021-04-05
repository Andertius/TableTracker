using System;
using System.Collections.Generic;

#nullable disable

namespace AppServerC
{
    public partial class User
    {
        public User()
        {
            Favourites = new HashSet<Favourite>();
            Histories = new HashSet<History>();
            PlaceSchemes = new HashSet<PlaceScheme>();
            UsersContactData = new HashSet<UsersContactDatum>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string Salt { get; set; }
        public int? Roles { get; set; }

        public virtual ICollection<Favourite> Favourites { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<PlaceScheme> PlaceSchemes { get; set; }
        public virtual ICollection<UsersContactDatum> UsersContactData { get; set; }
    }
}
