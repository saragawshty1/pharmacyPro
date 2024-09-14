namespace  Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set;}
        public string? Specialty { get; set;}
        public ICollection<Comment> Comments { get; set;}
    }
}
