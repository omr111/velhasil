using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class entryComment
    {
        public entryComment()
        {
            this.entryCommentLikes = new List<entryCommentLike>();
        }

        public int id { get; set; }
        public string entryComment1 { get; set; }
        public int entryId { get; set; }
        public Nullable<int> likeCount { get; set; }
        public virtual entry entry { get; set; }
        public virtual ICollection<entryCommentLike> entryCommentLikes { get; set; }
    }
}
