using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public enum Title
    {
        Psychologist = 1,
        Inspector,
        Senior_inspector,
        Chief
    }

    public class Employee
    {
        private string name;
        private string surname;
        private double period;
        private Title title;
        private const int baseSalary = 5050;

        public Employee(string name, string surname, double period, Title title)
        {
            Name = name;
            Surname = surname;
            this.period = period;
            this.title = title;
        }

        public string Name 
        { get => name; set => name = value; 
        }
        public string Surname 
        { get => surname; set => surname = value; 
        }

        public double Salary => baseSalary * (int)title * (period / 1.0 + 1);
        public double Tax => baseSalary * (int)title * 0.2;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Saya", "Xiao", 7, Title.Psychologist);
            Console.WriteLine($"Salary: {employee.Salary,0:0.00}");
            Console.WriteLine($"Tax: {employee.Tax}");
        }
    }
}
