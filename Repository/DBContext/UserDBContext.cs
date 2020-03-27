using Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DBContext
{
    class UserDBContext : DbContext
    {
       
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }
        public DbSet<EmployeeModel> Employees
        {
            get; set;
        }
        
    }
}

