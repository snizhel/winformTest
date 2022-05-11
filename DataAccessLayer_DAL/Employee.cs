using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class Employee
    {
        //properties
        //Fname, Minit, Lname, Ssn, Bdate, Address, Sex, Salary, Super_ssn, Dno
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string MiddletName { get; set; }
        public string LastName { get; set; }
        
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public decimal Salary { get; set; }
        public string SupperSsn { get; set; }
        public string DepartmentNumber { get; set; }

        // constructor
        public Employee() { }
    }
}
