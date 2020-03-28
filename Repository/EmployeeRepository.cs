//-----------------------------------------------------------------------
// <copyright file="EmployeeRepository.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Mayank Sachdeva"/>
//-----------------------------------------------------------------------

namespace Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    using Repository.DBContext;

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
        /// <returns>task integer</returns>
        public Task<int> AddEmployee(EmployeeModel employee)
        {
            this.userDBContext.Employees.Add(employee);
            var result = this.userDBContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>employee model type</returns>
        public EmployeeModel DeleteEmployee(int id)
        {
            EmployeeModel employee = this.userDBContext.Employees.Find(id);
            if (employee != null)
            {
                this.userDBContext.Employees.Remove(employee);
                this.userDBContext.SaveChanges();
            }

            return employee;
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>employee model type</returns>
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return this.userDBContext.Employees;
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>employee model type</returns>
        public EmployeeModel GetEmployee(int id)
        {
            return this.userDBContext.Employees.Find(id);
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns>task integer type</returns>
        public Task<int> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var employee = this.userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = this.userDBContext.SaveChangesAsync();
            return result;
        }
    }
}
