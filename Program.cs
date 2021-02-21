using System;

namespace Calc_f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer:");
            int operant1;
            operant1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operator:");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second integer:");

            int operant2 = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            switch (op)
            {
                case "+":
                    res = sum(operant1, operant2);
                    break;
                case "-":
                    res = subs(operant1, operant2);
                    break;
                case "/":
                    res = div(operant1, operant2);
                    break;
                case "*":
                    res = multi(operant1, operant2);
                    break;
                default:
                    Console.WriteLine("Operation isn't impelemented yet");
                    res = 0;
                    break;
            }

            Print_res(res);
        }

        static int sum(int a, int b)
        {
            return a + b;
        }
        static int multi(int a, int b)
        {
            return a * b;
        }
        static int subs(int a, int b)
        {
            return a - b;
        }
        // для деления добавить проверку на 0 если 0 - сообщение что делить на 0 нельзя и результат операции 
        // должен быть 0
        static int div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("It's impossible to divide by zero");
                return 0;
            }

            return a / b;
        }

        static void Print_res(int res)
        {
            Console.WriteLine("The result is: " + res);
        }
    }
}

