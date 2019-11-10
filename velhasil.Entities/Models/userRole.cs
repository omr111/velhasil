using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class userRole
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int roleId { get; set; }
        public virtual role role { get; set; }
        public virtual User User { get; set; }
    }
}
