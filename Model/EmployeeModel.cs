using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class EmployeeModel
    {
        private int    employeeID;
        private string name;
        private string emailID;
        private string password;
        private string mobile;
        private string address;

        public int EmpID
        {
            get
            {
                return this.employeeID;
            }
            set
            {
                this.employeeID = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }


        public string Email
        {
            get
            {
                return this.emailID;
            }
            set
            {
                this.emailID = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                this.mobile = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
    }
}
