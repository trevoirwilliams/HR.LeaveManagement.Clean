using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetLeaveRequestDetail;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries;

public class GetLeaveRequestDetailQuery : IRequest<LeaveRequestDetailsDto>
{
    public int Id { get; set; }
}
