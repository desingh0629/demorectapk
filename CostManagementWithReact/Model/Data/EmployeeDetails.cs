namespace CostManagementWithReact.Model.Data
{
    public class EmployeeDetails
    {
        public int EmployeeDetailsId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public string Address { get; set; } = "";
        public virtual Employee Employee { get; set; }
    }

}
