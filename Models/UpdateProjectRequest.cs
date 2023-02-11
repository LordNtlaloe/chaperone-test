namespace chaperone.Models
{
    public class UpdateProjectRequest
    {
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
