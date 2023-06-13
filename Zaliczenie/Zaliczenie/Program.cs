using System;

namespace Zaliczenie
{
    public class Calculator
    {
        static void Main()
        {
            Console.WriteLine("Hello world!");
        }
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Błąd! Nie można dzielić przez zero.");
                return 0;
            }
            return num1 / num2;
        }

        public double Power(double num, double exponent)
        {
            return Math.Pow(num, exponent);
        }

        public double SquareRoot(double num)
        {
            if (num < 0)
            {
                Console.WriteLine("Błąd! Nie można obliczyć pierwiastka z liczby ujemnej.");
                return 0;
            }
            return Math.Sqrt(num);
        }

        public double Modulo(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Błąd! Nie można obliczyć reszty z dzielenia przez zero.");
                return 0;
            }
            return num1 % num2;
        }

        public double NaturalLogarithm(double num)
        {
            if (num <= 0)
            {
                Console.WriteLine("Błąd! Logarytm naturalny można obliczyć tylko dla liczb dodatnich.");
                return 0;
            }
            return Math.Log(num);
        }
    }
}