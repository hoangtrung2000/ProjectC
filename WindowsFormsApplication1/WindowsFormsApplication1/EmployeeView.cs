using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class EmployeeView
    {
        public int id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public int Timework { get; set; }
        public int Salary { get; set; }

        public EmployeeView(Employee employee)
        {
            this.id = employee.id;
            this.Code = employee.Code;
            this.Name = employee.Name;
            this.Birthday = employee.Birthday;
            this.Address = employee.Address;
            this.Location = employee.Location.Name;
            this.Timework = employee.Timework;
            this.Salary = employee.Salary;
        }
    }
}
