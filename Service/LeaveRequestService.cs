using System;
using Model;
namespace Service
{
public static class LeaveRequestService
{
    public static string GetApprovalStatus(LeaveRequest request) =>
        request switch
        {
            { LeaveType: "SICK", Days: <= 2 } => "Auto Approved",
            { LeaveType: "SICK", Days: > 2 } => "Manager Approval Required",

            { LeaveType: "CASUAL", Days: <= 3 } => "Auto Approved",
            { LeaveType: "CASUAL", Days: > 3 } => "Manager Approval Required",

            { LeaveType: "EARNED" } => "HR Approval Required",

            _ => "Invalid Leave Type"
        };
}
}