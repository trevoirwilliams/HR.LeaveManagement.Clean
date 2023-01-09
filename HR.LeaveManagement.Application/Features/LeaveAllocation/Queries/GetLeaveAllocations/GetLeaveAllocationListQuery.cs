using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Queries.GetLeaveAllocations;

public class GetLeaveAllocationListQuery : IRequest<List<LeaveAllocationDto>>
{
}
