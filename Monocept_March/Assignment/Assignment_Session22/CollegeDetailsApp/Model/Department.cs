
namespace CollegeDetailsApp.Model
{
    internal class Department
    {
        private int _departmentId;
        private string _departmentName;
        private string _departmentCode;

        public Department(int departmentId, string departmentName, string departmentCode)
        {
            _departmentId = departmentId;
            _departmentName = departmentName;
            _departmentCode = departmentCode;
        }   
        public int DeptId { get { return _departmentId;  } }
        public string DepartmentName { get { return _departmentName; } }
        public string DepartmentCode { get { return _departmentCode; } }

    }
}
