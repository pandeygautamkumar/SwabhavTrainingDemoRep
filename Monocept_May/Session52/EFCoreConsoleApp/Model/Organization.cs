﻿

namespace EFCoreConsoleApp.Model
{
    public class Organization
    {
        public Guid Id { get; set; } 
        public string? Name { get; set; }
        public int EmployeeCount { get; set; }
    }
}
