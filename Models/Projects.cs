using System;

namespace backend.Models
{
    public class Projects
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsAvialable { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
