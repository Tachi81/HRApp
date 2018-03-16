using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRApp.Tests
{
    [TestFixture]
    public class CompanyTests
    {
        private Company _company;
        private Employee _employee;
        private string _expectedCompanyName;

        [SetUp]
        public void Init()
        {
            _expectedCompanyName = "15K_DeveloperCompany";
            _company = new Company(_expectedCompanyName);
            _employee = new Employee(
                Department.HumanResources,
                string.Empty,
                string.Empty,
                0,
                2000
            );
        }

        [Test]
        public void Should_CreateCompany_WhenNameIsSpecified()
        {
            Assert.That(_company.GetCompanyName(), Is.EqualTo(_expectedCompanyName));
        }

        [Test]
        public void Should_AddEmployee_WithDepartment_WhenFielsdAreSpecified()
        {
            Assert.That(_company.GetAllEmployees(Department.HumanResources).Count, Is.EqualTo(0));

            _company.AddEmployee(_employee);
            Assert.That(_company.GetAllEmployees(Department.HumanResources).Count, Is.EqualTo(1));
        }

        [Test]
        public void Should_GetEmployee_WhenFullNameIsSpecified()
        {
            _company.AddEmployee(_employee);
            var employee = _company.GetEmployeeByName(_employee.FirstName, _employee.LastName);

            Assert.That(_company.GetEmployeeByName(employee.FirstName, employee.LastName), Is.EqualTo(_employee));
        }

        [Test]
        public void Should_IncreaseEmployeeSalary_WhenPercentageIsSpecified()
        {
            var percentage = 15;
            var salaryBeforeIncrease = _employee.Salary;
            _employee.IncreaseSalary(percentage);

            Assert.That(_employee.Salary, Is.EqualTo(salaryBeforeIncrease*(decimal)(1+percentage/100.0)));
        }


    }
}
