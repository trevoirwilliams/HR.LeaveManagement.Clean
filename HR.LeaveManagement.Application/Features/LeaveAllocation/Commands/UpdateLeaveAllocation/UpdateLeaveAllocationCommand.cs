using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;

public class UpdateLeaveAllocationCommand : IRequest<Unit>
{
    public int Id { get; set; }
    public int NumberOfDays { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}
