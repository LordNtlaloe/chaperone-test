namespace chaperone.Models
{
    public class AddProjectRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
