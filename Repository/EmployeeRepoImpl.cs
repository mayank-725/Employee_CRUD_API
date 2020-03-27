using Model;
using Repository.DBContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepoImpl : IEmployeeRepo
    {
        private readonly UserDBContext userDBContext;

        public EmployeeRepoImpl(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        public Task<int> AddEmployee(EmployeeModel employee)
        {
            userDBContext.Employees.Add(employee);
            var result= userDBContext.SaveChangesAsync();
            return result;
        }


        public EmployeeModel DeleteEmployee(int id)
        {
            EmployeeModel employee = userDBContext.Employees.Find(id);
            if (employee != null)
            {
                userDBContext.Employees.Remove(employee);
                userDBContext.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return userDBContext.Employees;
        }

        public EmployeeModel GetEmployee(int id)
        {
            return userDBContext.Employees.Find(id);
        }

        public Task<int> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var employee = userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result =userDBContext.SaveChangesAsync();
            return result;
        }
    }
}
