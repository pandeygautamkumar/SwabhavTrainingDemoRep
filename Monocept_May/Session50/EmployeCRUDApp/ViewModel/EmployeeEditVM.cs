using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeCRUDApp.ViewModel
{
    public class EmployeeEditVM
    {
        public string Title { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public string ErrorMessage { get; set; }
    }
}