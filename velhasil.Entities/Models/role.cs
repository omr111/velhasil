using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class role
    {
        public role()
        {
            this.userRoles = new List<userRole>();
        }

        public int id { get; set; }
        public string roleName { get; set; }
        public virtual ICollection<userRole> userRoles { get; set; }
    }
}
