namespace HRMS.Dtos.Employee
{
    public class SearchEmployeeDto
    {
        public string ? Postion { get; set; }
        public string ? Name { get; set; }

        public bool? IsActive { get; set; }

        public string? PhoneNumber { get; set; }

        public decimal? MinSalary { get; set; }

        public decimal? MaxSalary { get; set; }
        public int? BirthYear { get; set; }

        public bool SalaryDescending { get; set; } = true;




    }
}
