using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRApp.Tests
{
    [TestFixture]
  public  class CompanyTests
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
                0
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
            Assert.That(_company.GetAllEmployees().Count, Is.EqualTo(0));
        }



    }
}
