namespace chaperone.Models
{
    public class AddUserRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ProjectID { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
