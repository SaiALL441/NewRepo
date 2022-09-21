using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public class Converter
    {
        private readonly double usd;
        private readonly double eur;
        private readonly double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ConvertUsd(double money, bool toUsd = true)
        {
            return toUsd ? money / usd : money * usd;
        }
        public double ConvertEur(double money, bool toEur = true)
        {
            return toEur ? money / eur : money * eur;
        }
        public double ConvertRub(double money, bool toRub = true)
        {
            return toRub ? money / rub : money * rub;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.9, 36.5, 0.6);

            
            Console.WriteLine(converter.ConvertUsd(10));
            Console.WriteLine(converter.ConvertUsd(10, false));
            Console.WriteLine();

            
            Console.WriteLine(converter.ConvertEur(10));
            Console.WriteLine(converter.ConvertEur(10, false));
            Console.WriteLine();

            
            Console.WriteLine(converter.ConvertRub(10));
            Console.WriteLine(converter.ConvertRub(10, false));
        }
    }
}
