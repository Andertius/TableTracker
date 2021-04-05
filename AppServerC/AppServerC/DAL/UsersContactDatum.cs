using System;
using System.Collections.Generic;

#nullable disable

namespace AppServerC
{
    public partial class UsersContactDatum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? UserId { get; set; }
        public string PhoneNumber { get; set; }

        public virtual User User { get; set; }
    }
}
