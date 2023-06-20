using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeCRUDApp.ViewModel
{
    public class EmployeeAddVM
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }
    }
}