using System.Collections.Generic;

namespace HRApp
{
    interface ICompany
    {
        void AddEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        string GetCompanyName();
    }
}