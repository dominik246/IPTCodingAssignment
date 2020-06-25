using System.Collections.Generic;

namespace AssignmentOne.Model
{
    class Employee
    {
        public int Name { get; set; }
        public decimal Salary { get; set; }
        public List<Employee> TeamMembers { get; set; }
    }
}
