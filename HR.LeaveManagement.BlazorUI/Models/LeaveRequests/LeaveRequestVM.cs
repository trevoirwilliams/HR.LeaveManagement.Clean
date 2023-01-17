using HR.LeaveManagement.BlazorUI.Models.LeaveTypes;
using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.BlazorUI.Models.LeaveRequests
{
    public class LeaveRequestVM
    {
        public int Id { get; set; }

        [Display(Name = "Date Requested")]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Date Actioned")]
        public DateTime DateActioned { get; set; }

        [Display(Name = "Approval State")]
        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }
        public LeaveTypeVM LeaveType { get; set; } = new LeaveTypeVM();
        public EmployeeVM Employee { get; set; } = new EmployeeVM();

        [Display(Name = "Start Date")]
        [Required]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Leave Type")]
        [Required]
        public int LeaveTypeId { get; set; }

        [Display(Name = "Comments")]
        [MaxLength(300)]
        public string? RequestComments { get; set; }

    }
}
