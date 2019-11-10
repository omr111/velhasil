using System;
using System.Collections.Generic;

namespace velhasil.Entities.Models
{
    public partial class ticket
    {
        public int id { get; set; }
        public string topicName { get; set; }
        public string message { get; set; }
        public string email { get; set; }
    }
}
