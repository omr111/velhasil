using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class entry
    {
        public entry()
        {
            this.entryComments = new List<entryComment>();
            this.userEntries = new List<userEntry>();
        }

        public int id { get; set; }
        public string entryCaption { get; set; }
        public int userId { get; set; }
        public int channelId { get; set; }
        public virtual channel channel { get; set; }
        public virtual ICollection<entryComment> entryComments { get; set; }
        public virtual ICollection<userEntry> userEntries { get; set; }
    }
}
