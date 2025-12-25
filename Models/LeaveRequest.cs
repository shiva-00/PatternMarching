using System;

namespace Model
{
    public record LeaveRequest
    (
        string EmployeeName,
        string LeaveType,
        int Days
    );
}