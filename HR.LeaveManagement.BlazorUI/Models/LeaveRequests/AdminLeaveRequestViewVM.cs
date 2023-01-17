using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.BlazorUI.Models.LeaveRequests
{
    public class AdminLeaveRequestViewVM
    {
        public int TotalRequests { get; set; }
        public int ApprovedRequests { get; set; }
        public int PendingRequests { get; set; }
        public int RejectedRequests { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; } = new List<LeaveRequestVM>();
    }
}
