using FluentValidation;
using HR.LeaveManagement.Application.Features.LeaveRequest.Commands.ChangeLeaveRequestApproval;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators;

public class ChangeLeaveRequestApprovalCommandValidator : AbstractValidator<ChangeLeaveRequestApprovalCommand>
{
    public ChangeLeaveRequestApprovalCommandValidator()
    {
        RuleFor(p => p.Approved)
            .NotNull()
            .WithMessage("Approval status cannot be null");
    }
}
