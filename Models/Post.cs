namespace Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; } 
        public string? PostContent { get; set; }
        public int? PatientID { get; set; }
        public Patient? Patients { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        
      
    }
}
