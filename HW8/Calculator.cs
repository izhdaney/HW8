using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Calculator
    {

        public double firstNumb;
        public double secondNumb;
        public char actionValue;
        public double result;


        public double GetResult()
        {

            if (actionValue == '+')
            {
                result = GetSum(firstNumb, secondNumb);
                Console.WriteLine($"Резульат операции {firstNumb} {actionValue} {secondNumb} = {result}");
            }
            else if (actionValue == '-')
            {
                result = GetSub(firstNumb, secondNumb);
                Console.WriteLine($"Result {firstNumb} {actionValue} {secondNumb} = {result}");
            }
            else if (actionValue == '*')
            {
                result = GetMult(firstNumb, secondNumb);
                Console.WriteLine($"Result {firstNumb} {actionValue} {secondNumb} = {result}");
            }
            else if (actionValue == '/' && secondNumb == 0)
            {
                Console.WriteLine($"Division by 0 is impossible.");
            }
            else if (actionValue == '/')
            {
                result = GetDiv(firstNumb, secondNumb);
                Console.WriteLine($"Result {firstNumb} {actionValue} {secondNumb} = {result}");
            }
            else
            {
                Console.WriteLine($"Wrong input. Please try again");
            }

            return result;
        }

        public double GetFirstNumb()
        {
            double returnValue;
            Console.WriteLine("Please Enter first number");
            do
            {
                if (double.TryParse(Console.ReadLine(), out returnValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please try again.");
                }
            } while (true);
            return returnValue;
        }

        public double GetSecondNumb()
        {
            double returnValue;
            Console.WriteLine("Please Enter second number");
            do
            {
                if (double.TryParse(Console.ReadLine(), out returnValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please try again.");
                }
            } while (true);
            return returnValue;
        }

        public char GetActionValue()
        {
            Console.WriteLine("Please select an action (+, -, /, *)");

            char returnValue;

            do
            {
                if (char.TryParse(Console.ReadLine(), out returnValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please try again.");
                }
            } while (true);
            return returnValue;
        }

        private double GetSum(double firstNumb, double secondNumb)
        {
            return firstNumb + secondNumb;
        }

        private double GetDiv(double firstNumb, double secondNumb)
        {
            return firstNumb / secondNumb;
        }

        private double GetSub(double firstNumb, double secondNumb)
        {
            return firstNumb - secondNumb;
        }

        private double GetMult(double firstNumb, double secondNumb)
        {
            return firstNumb * secondNumb;
        }
    }
}
