using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Identity;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IUserService _userService;

        public CreateLeaveAllocationCommandHandler(IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository, ILeaveTypeRepository leaveTypeRepository,
            IUserService userService)
        {
            _mapper = mapper;
            this._leaveAllocationRepository = leaveAllocationRepository;
            this._leaveTypeRepository = leaveTypeRepository;
            this._userService = userService;
        }

        public async Task<Unit> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveAllocationCommandValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
                throw new BadRequestException("Invalid Leave Allocation Request", validationResult);

            // Get Leave type for allocations
            var leaveType = await _leaveTypeRepository.GetByIdAsync(request.LeaveTypeId);

            // Get Employees
            var employees = await _userService.GetEmployees();

            //Get Period
            var period = DateTime.Now.Year;

            //Assign Allocations IF an allocation doesn't already exist for period and leave type
            var allocations = new List<Domain.LeaveAllocation>();
            foreach (var emp in employees)
            {
                var allocationExists = await _leaveAllocationRepository.AllocationExists(emp.Id, request.LeaveTypeId, period);

                if(allocationExists == false)
                {
                    allocations.Add(new Domain.LeaveAllocation
                    {
                        EmployeeId = emp.Id,
                        LeaveTypeId = leaveType.Id,
                        NumberOfDays = leaveType.DefaultDays,
                        Period = period,
                    });
                }
            }

            if (allocations.Any())
            {
                await _leaveAllocationRepository.AddAllocations(allocations);
            }
            
            return Unit.Value;
        }
    }
}
