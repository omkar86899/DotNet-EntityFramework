using OneToManyApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            AurionProDBContext db;
            Department department1, department2;
            Employee employee1, employee2, employee3, employee4;
            
            db = new AurionProDBContext();

            department1 = new Department { DeptNo = 10, DeptName = "Accounting", Location = "Mumbai" };
            department2 = new Department { DeptNo = 20, DeptName = "Sales", Location = "Thane" };

            employee1 = new Employee { EmpNo = 100, Name = "omkar", Dept = department1 };
            employee2 = new Employee { EmpNo = 101, Name = "sachin", Dept = department1 };

            employee3 = new Employee { EmpNo = 102, Name = "rahul", Dept = department2 };
            employee4 = new Employee { EmpNo = 103, Name = "vishal", Dept = department2 };

            department1.Employees = new List<Employee>();
            department1.Employees.Add(employee1);
            department1.Employees.Add(employee2);

            department2.Employees = new List<Employee>();
            department2.Employees.Add(employee3);
            department2.Employees.Add(employee4);

            db.Employees.Add(employee1);
            db.Employees.Add(employee2);
            db.Employees.Add(employee3);
            db.Employees.Add(employee4);

            db.Departments.Add(department1);
            db.Departments.Add(department2);

            db.SaveChanges();

            Console.WriteLine("Printing All Employee Details: ");
            PrintAllEmployeesDetails(db.Employees);
            Console.WriteLine("\nPrinting All Department Details With Their Employees: ");
            PrintAllDepartmentsWithTheirEmployees(db.Departments);
            Console.WriteLine("\nPrinting All Employees With Their Department Name: ");
            PrintAllEmployeesWithTheirDeptName(db.Employees);
        }

        private static void PrintAllEmployeesWithTheirDeptName(DbSet<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                Console.WriteLine("Employee number: " + employee.EmpNo);
                Console.WriteLine("Name: " + employee.Name);
                Console.WriteLine("Department Name: " + employee.Dept.DeptName);
            }
        }

        private static void PrintAllDepartmentsWithTheirEmployees(DbSet<Department> departments)
        {
            foreach(Department department in departments)
            {
                Console.WriteLine("Department No: "+department.DeptNo);
                Console.WriteLine("Department Name: "+department.DeptName);
                Console.WriteLine("Location: " + department.Location);

                Console.WriteLine("Employees Under This Department: ");
                PrintAllEmployeesDetails(department.Employees);
                Console.WriteLine();
            }
        }

        private static void PrintAllEmployeesDetails(IEnumerable<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                Console.WriteLine("Employee number: " + employee.EmpNo);
                Console.WriteLine("Name: " + employee.Name);
            }
        }
    }
}
