namespace  Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public decimal? Height { get; set;}
        public decimal? Weight { get; set;}
        public Boolean? IsAlzehimer { get; set;}
        public Boolean? IsAntiallergic { get; set;}
        public Boolean? IsAntidepressants { get; set;}
        public Boolean? IsAppetizers { get; set;}
        public Boolean? IsCough  { get; set;}
        public Boolean? IsDiabetes { get; set;}
        public Boolean? IsInfluenza { get; set;}
        public Boolean? IsMassage { get; set;}
        public Boolean? IsMultivitamins{ get; set;}
        public Boolean? IscvsHypertension{ get; set;}
        public Boolean? IscvsHypotension{ get; set;}
        public Boolean? IscvsAnticoagulant{ get; set;}
        public DateTime? CreatedDate { get; set;}
        public ICollection<Post>? Posts { get; set;}
        public ICollection<Order>? orders { get; set;}
    }
    
}
