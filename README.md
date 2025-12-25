# Leave Approval System (C#)

This is a simple console-based C# application that simulates a basic leave approval process used in many organizations.

I built this project to practice and demonstrate modern C# concepts such as records, and pattern matching, while keeping the logic realistic and easy to understand.

The application takes employee input from the console and decides whether a leave request is auto-approved or requires manager/HR approval based on predefined rules.

---

## What the application does

- Accepts employee name, leave type, and number of leave days
- Supports Sick, Casual, and Earned leave types
- Automatically evaluates leave approval rules
- Displays the approval status immediately
- Allows multiple requests in a single run

---

## Leave approval rules

- **Sick Leave**
  - Up to 2 days → Auto Approved
  - More than 2 days → Manager Approval Required

- **Casual Leave**
  - Up to 3 days → Auto Approved
  - More than 3 days → Manager Approval Required

- **Earned Leave**
  - Always requires HR Approval

---

## Concepts used in this project

- C# Records for immutable data modeling
- Switch pattern matching for clean business logic
- Console input/output handling
- Separation of concerns using Models and Services

---

## Project structure

  LeaveApprovalSystem/
  │
  ├── src/
  │ └── LeaveApprovalSystem/
  │ ├── Models/
  │ ├── Enums/
  │ ├── Services/
  │ └── Program.cs
  │
  └── README.md


## How to run the project

Make sure you have .NET SDK installed.

From the project folder, run:
 - dotnet run



