using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp
{
    class Company : ICompany
    {
        private readonly string _name;
        private readonly List<Employee> _employees;

        public Company(string name)
        {
            _name = name;
            _employees= new List<Employee>();
        }

        public string GetCompanyName()
        {
            return "";
        }

        public void AddEmployee(Employee employee)
        {

        }

        public List<Employee> GetAllEmployees()
        {
            // TODO add functionality
            throw new NotImplementedException();
        }

    }
}
