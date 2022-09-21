using System;
using System.Collections;
using System.Text;


namespace lect02
{
    public class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private int apartment;

        public string Index { get => index; set => index = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string House { get => house; set => house = value; }
        public int Apartment { get => apartment; set => apartment = value; }

        public override string ToString()
        {
            return $"{Index}, {Country}: {City}; {Street} {House}, {Apartment}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address b = new Address
            {
                Index = "06848",
                Country = "Ukraine",
                City = "Odessa",
                Street = "Belin",
                House = "2B",
                Apartment = 11
            };

            Console.WriteLine(b.ToString());
        }
    }
}
