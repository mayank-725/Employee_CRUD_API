﻿using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    /// <summary>
    /// employee manager class 
    /// </summary>
    /// <seealso cref="Manager.IEmployeeManager" />
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// The repo
        /// </summary>
        private readonly IEmployeeRepository repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        public EmployeeManager(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>task integer</returns>
        public Task<int> AddEmployee(EmployeeModel employee)
        {
            var result= this.repo.AddEmployee(employee);
            return result;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public EmployeeModel DeleteEmployee(int id)
        {
            return this.repo.DeleteEmployee(id);
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return this.repo.GetAllEmployees();
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public EmployeeModel GetEmployee(int id)
        {
            return this.repo.GetEmployee(id);
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var result= this.repo.UpdateEmployee(employeeChanges);

            return result;
        }
    }
}