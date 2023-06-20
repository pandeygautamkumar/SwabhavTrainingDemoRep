
using EmployeCRUDApp.Models;
using System.Collections.Generic;

namespace EmployeCRUDApp.ViewModel
{
    public class EmployeeIndexVM
    {
        public int Count { get; set; }
        public string Title { get; set; }
        public List<Employee> Employees { get; set; }   
    }
}