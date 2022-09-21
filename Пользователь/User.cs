using System;
using System.Collections.Generic;

namespace User
{
    public class User
    {
        private string name;
        private string surname;
        private int age;
        private string date;
        private readonly DateTime joinDate = DateTime.Today;

        public User(string name, string surname, int age, string date)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Date = date;
        }

        public DateTime JoinDate => joinDate;

        public string Name 
        { get => name; set => name = value;
        }
        public string Surname 
        { get => surname; set => surname = value; 
        }
        public int Age 
        { get => age; set => age = value;
        }
        public string Date 
        { get => date; set => date = value; 
        }

        public override string ToString()
        {
            return $"Name: {Name,-5} Surname: {Surname,-10} Date: {Date,-15} Age: {Age,-5} Joined: {JoinDate.ToShortDateString()}";
        }
    } 


    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Saya", "Xiao", 18, "02.05.2022");
            Console.WriteLine(user.ToString());
        }
    }
}
