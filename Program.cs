using System;
using Model;
using Service;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nEnter employee name: ");
            string name = Console.ReadLine()!.Trim();

            Console.Write("Enter leave type (Sick / Casual / Earned): ");
            string leaveType = Console.ReadLine()!.Trim().ToUpper();

            Console.Write("Enter number of days: ");
            int days = int.Parse(Console.ReadLine()!);

            var request = new LeaveRequest(name, leaveType, days);

            Console.WriteLine(
                $"Leave Status: {LeaveRequestService.GetApprovalStatus(request)}"
            );

            Console.Write("\nPress ENTER to continue or type EXIT to quit: ");
            if (Console.ReadLine()?.Trim().Equals("EXIT", StringComparison.OrdinalIgnoreCase) == true)
                break;
        }
    }
}
