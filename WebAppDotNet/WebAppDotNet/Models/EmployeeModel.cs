namespace WebAppDotNet.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public required string EmpName { get; set; }
        public required string EmpDesignation { get; set; }
        public int EmpSalary { get; set; }
    }
}
