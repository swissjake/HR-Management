
namespace HR.LeaveManagement.Application.DTOs;

public class LeaveApplicationDto : BaseDto
{
    public int NumberOfDays { get; set; }
    public int LeaveTypeId { get; set; }
    public LeaveTypeDto? LeaveType { get; set; }

    public int Period { get; set; }

}
