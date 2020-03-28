using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public  interface IEmployeeRepo
    {
        EmployeeModel GetEmployee(int id);
        IEnumerable<EmployeeModel> GetAllEmployees();
        Task<int> AddEmployee(EmployeeModel employee);
        Task<int> UpdateEmployee(EmployeeModel employeeChanges);
        EmployeeModel DeleteEmployee(int id);
    }
}
