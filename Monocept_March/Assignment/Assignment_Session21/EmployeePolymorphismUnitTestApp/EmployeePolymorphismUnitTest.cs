
using EmployeePolymorphism.Model;
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphismUnitTestApp
{
    [TestClass]
    public class EmployeePolymorphismUnitTest
    {
        [TestMethod]
        public void Should_Check_Employee_Class_Constructor_Throught_Manager_Class_Constructor_By_Overriding_Constructor()
        {
            Employee employee = new Manager(12, "Gautam", 10000);
            int expectedEmployeeId = 12;
            string expectedEmployeeName = "Gautam";
            double expectedEmployeeBasicSalary = 10000;
            string expectedRole = "Manager";
            Assert.AreEqual(expectedEmployeeId,employee.Id);
            Assert.AreEqual(expectedEmployeeName, employee.Name);
            Assert.AreEqual(expectedEmployeeBasicSalary, employee.BasicSalary);
            Assert.AreEqual(expectedRole, employee.Role);
        }
        [TestMethod]
        public void Should_Check_Employee_Class_Constructor_Throught_Developer_Class_Constructor_By_Overriding_Constructor()
        {
            Employee employee = new Developer(10, "Ravi", 15000);
            int expectedEmployeeId = 10;
            string expectedEmployeeName = "Ravi";
            double expectedEmployeeBasicSalary = 15000;
            string expectedRole = "Developer";
            Assert.AreEqual(expectedEmployeeId, employee.Id);
            Assert.AreEqual(expectedEmployeeName, employee.Name);
            Assert.AreEqual(expectedEmployeeBasicSalary, employee.BasicSalary);
            Assert.AreEqual(expectedRole, employee.Role);
        }
        [TestMethod]
        public void Should_Check_Employee_Class_Constructor_Throught_QualityAnalyst_Class_Constructor_By_Overriding_Constructor()
        {
            Employee employee = new QualityAnalyst(101, "Shubh", 12000);
            int expectedEmployeeId = 101;
            string expectedEmployeeName = "Shubh";
            double expectedEmployeeBasicSalary = 12000;
            string expectedRole = "QualityAnalyst";

            Assert.AreEqual(expectedEmployeeId, employee.Id);
            Assert.AreEqual(expectedEmployeeName, employee.Name);
            Assert.AreEqual(expectedEmployeeBasicSalary, employee.BasicSalary);
            Assert.AreEqual(expectedRole, employee.Role);
        }
        [TestMethod]
        public void Should_Check_the_HouserentAllowance_TravellingAllowance_DearnessAllowance_Of_Manager()
        {
            Manager manager= new Manager(12, "Gautam", 10000);
            int expectedEmployeeId = 12;
            string expectedEmployeeName = "Gautam";
            double expectedEmployeeBasicSalary = 10000;
            string expectedRole = "Manager";

            double expectedHouserentAllowance = 6000;
            double expectedTravellingAllowance = 5000;
            double expectedDearnessAllowance = 4000;

            Assert.AreEqual(expectedEmployeeId, manager.Id);
            Assert.AreEqual(expectedEmployeeName, manager.Name);
            Assert.AreEqual(expectedEmployeeBasicSalary, manager.BasicSalary);
            Assert.AreEqual(expectedRole, manager.Role);

            Assert.AreEqual(expectedHouserentAllowance, manager.HouseRentAllowance);
            Assert.AreEqual(expectedTravellingAllowance, manager.TravellingAllowance);
            Assert.AreEqual(expectedDearnessAllowance, manager.DearnessAllowance);
        }
        [TestMethod]
        public void Should_Check_the_PorformanceAllowance_OverTimeAllowance_Of_Developer()
        {
            Developer developer = new Developer(15, "Gautam", 8000);
            int expectedEmployeeId = 15;
            string expectedEmployeeName = "Gautam";
            double expectedEmployeeBasicSalary =8000;
            string expectedRole = "Developer";

            double expectedPorformanceAllowance = 4000;
            double expectedOverTimeAllowance = 3200;

            Assert.AreEqual(expectedEmployeeId, developer.Id);
            Assert.AreEqual(expectedEmployeeName, developer.Name);
            Assert.AreEqual(expectedEmployeeBasicSalary, developer.BasicSalary);
            Assert.AreEqual(expectedRole, developer.Role);

            Assert.AreEqual(expectedPorformanceAllowance, developer.PerformanceAllowance);
            Assert.AreEqual(expectedOverTimeAllowance,developer.OverTimeAllowance);
        }

        [TestMethod]
        public void Should_Check_the_Perks_Of_QualityAnalys()
        {
            QualityAnalyst qAnalyst = new QualityAnalyst(101, "Shubh", 12000);
            int expectedEmployeeId = 101;
            string expectedEmployeeName = "Shubh";
            double expectedEmployeeBasicSalary = 12000;
            string expectedRole = "QualityAnalyst";
            double expectedPerk = 4800;

            Assert.AreEqual(expectedEmployeeId, qAnalyst.Id);
            Assert.AreEqual(expectedEmployeeName, qAnalyst.Name);
            Assert.AreEqual(expectedEmployeeBasicSalary, qAnalyst.BasicSalary);
            Assert.AreEqual(expectedRole, qAnalyst.Role);
            Assert.AreEqual(expectedPerk,qAnalyst.Perk);
        }
        [TestMethod]
        public void Should_Check_the_CostToCompany_Of_Manager_And_SalaryBreakup_Of_Manager()
        {
            Employee employee = new Manager(12, "Gautam", 10000);
            double expectecCostToCompany = 300000;
            string expectedSalaryBreakup = $"House Rent Allowance : {6000}  Travelling Allowanace : {5000}  Dearness Allowance :  {4000}";

            Assert.AreEqual(expectecCostToCompany,employee.CostToCompany);
            Assert.AreEqual(expectedSalaryBreakup, employee.SalaryBreakUp);
        }
        [TestMethod]
        public void Should_Check_the_CostToCompany_Of_Developer_And_SalaryBreakup_Of_Developer()
        {
            Employee employee = new Developer(10, "Ravi", 15000);
            double expectecCostToCompany = 342000;

            string expectedSalaryBreakup = $"Performance Allowance : {7500}  OverTime Allownace is : {6000}";

            Assert.AreEqual(expectecCostToCompany, employee.CostToCompany);
            Assert.AreEqual(expectedSalaryBreakup, employee.SalaryBreakUp);
        }
        [TestMethod]
        public void Should_Check_the_CostToCompany_Of_Developer_And_SalaryBreakup_Of_QualityAnalyst()
        {
            Employee employee = new QualityAnalyst(101, "Shubh", 12000);
            double expectecCostToCompany = 201600;

            string expectedSalaryBreakup = $"Perks is : {4800}";

            Assert.AreEqual(expectecCostToCompany, employee.CostToCompany);
            Assert.AreEqual(expectedSalaryBreakup, employee.SalaryBreakUp);
        }
    }
}
