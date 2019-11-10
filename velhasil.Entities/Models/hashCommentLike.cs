using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class hashCommentLike
    {
        public int id { get; set; }
        public int hashCommentId { get; set; }
        public int userId { get; set; }
    }
}
