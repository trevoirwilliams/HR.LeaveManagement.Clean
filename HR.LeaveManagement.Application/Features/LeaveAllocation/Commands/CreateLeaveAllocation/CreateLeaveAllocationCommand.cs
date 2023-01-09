using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;

public class CreateLeaveAllocationCommand : IRequest<Unit>
{
    public int LeaveTypeId { get; set; }
}
