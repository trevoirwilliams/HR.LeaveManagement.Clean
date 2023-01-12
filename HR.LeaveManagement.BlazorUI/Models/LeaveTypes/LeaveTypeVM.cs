using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HR.LeaveManagement.BlazorUI.Models.LeaveTypes
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Default Number Of Days")]
        public int DefaultDays { get; set; }
    }
}
