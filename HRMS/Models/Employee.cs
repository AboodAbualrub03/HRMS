namespace HRMS.Models
{
    public class Employee // Model
    {
        public long Id { get; set; } //Required

        public  string FirstName { get; set; }//Required

        public  string LastName { get; set; }//Required

        public  string? Email { get; set; }//Optional / nullable(null)

        public string Position { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }//07, 962+
        
        public bool IsActive { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? Salary { get; set; }

    }
}
