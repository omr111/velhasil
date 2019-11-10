using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class entryCommentLike
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int entryCommentId { get; set; }
        public virtual entryComment entryComment { get; set; }
        public virtual User User { get; set; }
    }
}
