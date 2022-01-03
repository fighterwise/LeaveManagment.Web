using Microsoft.AspNetCore.Identity;

namespace LeaveManagment.Web.Data
{
    public class Employee : IdentityUser   // გამოვიყენოთ მემკვიდრეობით აიდენთითიიუზერის კონიგურაცია
    { 
        public string? FirstnameName { get; set; }    
        public string? Lastname { get; set; }

        public string? TaxId { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateJoined { get; set; }    







    }
}
