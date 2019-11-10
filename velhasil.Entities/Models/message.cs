using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class message
    {
        public int id { get; set; }
        public int fromWhoId { get; set; }
        public string message1 { get; set; }
        public int whomId { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
