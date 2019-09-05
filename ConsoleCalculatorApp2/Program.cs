using System;

namespace ConsoleCalculatorApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0;
            char ops;

            do
            {
                Console.Clear();
                Console.ResetColor();

                Console.Write("Enter operand 1 : ");
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Select an operator (+, - , * , / , % , ^ , sqrt (s), percentage (d)) : ");
                ops = Convert.ToChar(Console.ReadLine());

                if (ops != 's')
                {
                    Console.Write("Enter operand 2 : ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                }

                if (ops == '+')
                    display(ops, add(n1, n2), n1, n2);
                else if (ops == '-')
                    display(ops, sub(n1, n2), n1, n2);
                else if (ops == '*')
                    display(ops, mul(n1, n2), n1, n2);
                else if (ops == '/')
                    display(ops, div(n1, n2), n1, n2);
                else if (ops == '%')
                    display(ops, modulus(n1, n2), n1, n2);
                else if (ops == '^')
                    display(ops, pow(n1, n2), n1, n2);
                else if (ops == 's')
                    sqrt(n1);
                else if (ops == 'd')
                    display(ops, percentage(n1, n2), n1, n2);
                else
                    Console.WriteLine("Invalid Operator!");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPress 'Y' to continue or 'N' to exit the process : ");
            } while (Console.ReadKey().Key == ConsoleKey.Y);
        }
        static void display(char ops, double result, double n1, double n2)
        {
            if (ops == 'd')
                Console.WriteLine("Percentage of " + n1 + "/" + n2 + " * 100 = " + result);
            else
                Console.WriteLine(n1 + " " + ops + " " + n2 + " = " + result);
        }

        public static double add(double x, double y)
        {
            return x + y;
        }

        static double sub(double x, double y)
        {
            return x - y;
        }

        static double mul(double x, double y)
        {
            return x * y;
        }

        static double div(double x, double y)
        {
            return x / y;
        }

        static double modulus(double n, double p)
        {
            return (int)n % (int)p;
        }

        static double pow(double x, double y)
        {
            return Math.Pow(x, y);
        }

        static void sqrt(double x)
        {
            Console.WriteLine("Sqrt(" + x + ") = " + Math.Sqrt(x));
        }

        static double percentage(double x, double y)
        {
            return ((x / y) * 100);
        }
    }
}
