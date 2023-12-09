using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9DZ
{
    public class Employee
    {
        private string name;
        private int age;
        private double salary;

        public Employee()
        {
        }

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nSalary: {salary:C}");
        }

        public double CalculateAnnualSalary()
        {
            return salary * 12;
        }

        public void SetDataFromConsole()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter age: ");
            int.TryParse(Console.ReadLine(), out age);

            Console.Write("Enter monthly salary: ");
            double.TryParse(Console.ReadLine(), out salary);
        }
    }

    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();

            employee.SetDataFromConsole();

            employee.GetInfo();

            double annualSalary = employee.CalculateAnnualSalary();
            Console.WriteLine($"Annual Salary: {annualSalary:C}");
        }
    }

}
