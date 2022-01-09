using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Names")]
        public string Name { get; set; }

        [Display(Name = "Default Number OF Days")]
        public int DefaultDays { get; set; }

    }
}
