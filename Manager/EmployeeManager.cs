using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ManagerImpl : IManager
    {
        private readonly IEmployeeRepository repo;

        public ManagerImpl(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        public Task<int> AddEmployee(EmployeeModel employee)
        {
            var result= this.repo.AddEmployee(employee);
            return result;
        }

        public EmployeeModel DeleteEmployee(int id)
        {
            return this.repo.DeleteEmployee(id);
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return this.repo.GetAllEmployees();
        }

        public EmployeeModel GetEmployee(int id)
        {
            return this.repo.GetEmployee(id);
        }

        public Task<int> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var result= this.repo.UpdateEmployee(employeeChanges);

            return result;
        }
    }
}