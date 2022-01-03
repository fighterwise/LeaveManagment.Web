using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagment.Web.Data
{
    public class LeaveAllocation:BaseEntity  // ახალი დეითბეისის თეიბლი.
    {
        // გადავიტანეტ მშობელ კლასში public int Id { get; set; }  // ეს არის ამ ახალი თეიბლის რათქმაუნდა სვეტი პრიმარი კეი.

        public int NumberOfDays { get; set; }  // დღეები

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }


        //გადავიტანეთ მშობელ კლასში public DateTime DateCreated { get; set; }
        //გადავიტანეთ მშობელ კლასში public DateTime DateModified { get; set; }
         
        



    }
}
