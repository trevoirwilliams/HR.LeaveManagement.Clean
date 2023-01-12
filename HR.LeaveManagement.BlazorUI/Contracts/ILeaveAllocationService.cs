using HR.LeaveManagement.BlazorUI.Services.Base;

namespace HR.LeaveManagement.BlazorUI.Contracts
{
    public interface ILeaveAllocationService
    {
        Task<Response<Guid>> CreateLeaveAllocations(int leaveTypeId);
    }
}
