namespace CostManagementWithReact.Model.Data
{
    public class Salary
    {
        public int SalaryId { get; set; }
        public int EmployeeId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Deductions { get; set; }
        // Other salary-related properties
        public int EmployeeAttendanceId { get; set; }
        public int EmployeeDetailsId { get; set; }
       
    }

}
