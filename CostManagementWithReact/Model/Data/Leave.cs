namespace CostManagementWithReact.Model.Data
{
    public class Leave
    {
        public int LeaveId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public int EmployeeDetailsId { get; set; }
        // Other leave-related properties
    }

}
