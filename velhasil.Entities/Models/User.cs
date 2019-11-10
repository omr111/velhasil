using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class User
    {
        public User()
        {
            this.channels = new List<channel>();
            this.entryCommentLikes = new List<entryCommentLike>();
            this.messages = new List<message>();
            this.messages1 = new List<message>();
            this.userEntries = new List<userEntry>();
            this.userRoles = new List<userRole>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string userNote { get; set; }
        public virtual ICollection<channel> channels { get; set; }
        public virtual ICollection<entryCommentLike> entryCommentLikes { get; set; }
        public virtual ICollection<message> messages { get; set; }
        public virtual ICollection<message> messages1 { get; set; }
        public virtual ICollection<userEntry> userEntries { get; set; }
        public virtual ICollection<userRole> userRoles { get; set; }
    }
}
