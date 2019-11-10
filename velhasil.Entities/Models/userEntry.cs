using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class userEntry
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int entryId { get; set; }
        public int channelId { get; set; }
        public virtual channel channel { get; set; }
        public virtual entry entry { get; set; }
        public virtual User User { get; set; }
    }
}
