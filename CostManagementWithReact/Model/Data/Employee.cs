using System.ComponentModel.DataAnnotations;

namespace CostManagementWithReact.Model.Data
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; } = "";
        public string ContactNumber { get; set; } = "";
        // Other properties specific to employees
    }

}
