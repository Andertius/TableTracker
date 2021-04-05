using System;
using System.Collections.Generic;

#nullable disable

namespace AppServerC
{
    public partial class History
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? PlaceId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Place Place { get; set; }
        public virtual User User { get; set; }
    }
}
