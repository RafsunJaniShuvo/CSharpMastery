using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public partial class Employee
    {
        public Employee(int id, string Name)
        {
            // this.EmpID = id;
            this.GenerateEmployeeId();
            this.Name = Name;
        }

        public void DisplayEmpInfo()
        {
            Console.WriteLine($"EmpId : {this.EmpID} , Name : {this.Name}");
        }

        partial void GenerateEmployeeId()
        {
            Random random = new Random();
            this.EmpID = random.Next(1, 1000);
        }
    }
}
