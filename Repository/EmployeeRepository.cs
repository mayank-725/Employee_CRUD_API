using Model;
using Repository.DBContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// employee repository class
    /// </summary>
    /// <seealso cref="Repository.IEmployeeRepository" />
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// The user database context
        /// </summary>
        private readonly UserDBContext userDBContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRepository"/> class.
        /// </summary>
        /// <param name="userDBContext">The user database context.</param>
        public EmployeeRepository(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public Task<int> AddEmployee(EmployeeModel employee)
        {
            userDBContext.Employees.Add(employee);
            var result= userDBContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return userDBContext.Employees;
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public EmployeeModel GetEmployee(int id)
        {
            return userDBContext.Employees.Find(id);
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var employee = userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result =userDBContext.SaveChangesAsync();
            return result;
        }
    }
}
