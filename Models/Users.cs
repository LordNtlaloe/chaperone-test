using System;

namespace backend.Models
{
    public class Users
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string ProjectID { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
