using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class channel
    {
        public channel()
        {
            this.entries = new List<entry>();
            this.userEntries = new List<userEntry>();
        }

        public int id { get; set; }
        public int autohorId { get; set; }
        public string channelName { get; set; }
        public virtual ICollection<entry> entries { get; set; }
        public virtual ICollection<userEntry> userEntries { get; set; }
        public virtual User User { get; set; }
    }
}
