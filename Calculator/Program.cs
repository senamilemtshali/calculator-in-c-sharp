using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Calculator");
            Console.WriteLine("calculator can only perform the following operations: + - * /");

            // Prompt user to enter first number
            Console.Write("Please enter your number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            string inputOperator;
            bool isValidOperator = false;

            do
            {
                Console.Write("Please enter a valid operator: ");
                inputOperator = Console.ReadLine();

                if (inputOperator == "+" || inputOperator == "-" || inputOperator == "*" || inputOperator == "/")
                {
                    isValidOperator = true;
                }
                else
                {
                    Console.WriteLine("Invalid operator. Please try again.");
                }
            } while (!isValidOperator);

            Console.Write("Please enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (inputOperator == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (inputOperator == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (inputOperator == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (inputOperator == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            Console.ReadLine();
        }
    }
}
