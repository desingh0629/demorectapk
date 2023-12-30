namespace CostManagementWithReact.Model.Data
{
    public class Allowance
    {
        public int AllowanceId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeDetailsId { get; set; }
    }

}
