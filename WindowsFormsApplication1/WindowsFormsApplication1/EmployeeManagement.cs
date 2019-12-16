using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class EmployeeManagement
    {
        public Employee[] GetEmployees()
        {
            var db = new IMDatabaseEntities();
            return db.Employee.ToArray();
        }
        public Employee GetEmployee(int id)
        {
            var db = new IMDatabaseEntities();
            return db.Employee.Find(id);
        }
        public void CreateEmployee(string code, string name, DateTime birthday, string address, int location_id, int timework, int salary)
        {
            var employee = new Employee();
            employee.Code = code;
            employee.Name = name;
            employee.Birthday = birthday;
            employee.Address = address;
            employee.Location_id = location_id;
            employee.Timework = timework;
            employee.Salary = salary;

            var db = new IMDatabaseEntities();
            db.Employee.Add(employee);
            db.SaveChanges();
        }
        public void UpdateEmployee(int id, string code, string name, DateTime birthday, string address, int location_id, int timework, int salary)
        {
            var db = new IMDatabaseEntities();
            var employee = db.Employee.Find(id);

            employee.Code = code;
            employee.Name = name;
            employee.Birthday = birthday;
            employee.Address = address;
            employee.Location_id = location_id;
            employee.Timework = timework;
            employee.Salary = salary;

            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            var db = new IMDatabaseEntities();
            var employee = db.Employee.Find(id);

            db.Employee.Remove(employee);
            db.SaveChanges();
        }
        public Location[] GetLocations()
        {
            var db = new IMDatabaseEntities();
            return db.Location.ToArray();
        }
        
    }
}
