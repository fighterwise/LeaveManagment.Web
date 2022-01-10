using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Names")]
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Default Number OF Days")]
        [Range(1, 25, ErrorMessage = "Please Enter Valid Number")]
        public int DefaultDays { get; set; }

    }
}
