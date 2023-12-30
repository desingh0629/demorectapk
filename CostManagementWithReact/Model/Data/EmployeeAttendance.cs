using System.ComponentModel.DataAnnotations;

namespace CostManagementWithReact.Model.Data
{
    public class EmployeeAttendance
    {
        [Key]
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public int HoursWorked { get; set; }
        public int EmployeeDetailsId { get; set; }

    }

}
