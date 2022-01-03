using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagment.Web.Data
{
    public class LeaveAllocation  // ახალი დეითბეისის თეიბლი.
    {
        public int Id { get; set; }  // ეს არის ამ ახალი თეიბლის რათქმაუნდა სვეტი პრიმარი კეი.

        public int NumberOfDays { get; set; }  // დღეები

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }


        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
         
        



    }
}
