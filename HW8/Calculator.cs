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


        public void Print()
        {
            GetResult();
            Console.WriteLine($"Резульат операции {firstNumb} {actionValue} {secondNumb} = {result}");
        }

        public double GetResult()
        {
            //firstNumb = GetFirstNumb();
            //actionValue = GetActionValue();
            //secondNumb = GetSecondNumb();

            if (actionValue == '+')
            {
                result = GetSum(firstNumb, secondNumb);
            }
            if (actionValue == '-')
            {
                result = GetSub(firstNumb, secondNumb);
            }
            if (actionValue == '*')
            {
                result = GetMult(firstNumb, secondNumb);
            }
            if (secondNumb == 0 && actionValue == '/')
            {
                Console.WriteLine($"Деление на ноль невозможно.");
            }
            if (actionValue == '/')
            {
                result = GetDiv(firstNumb, secondNumb);
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
            double result = firstNumb + secondNumb;
            return result;
        }

        private double GetDiv(double firstNumb, double secondNumb)
        {
            double result = firstNumb / secondNumb;
            return result;
        }

        private double GetSub(double firstNumb, double secondNumb)
        {
            double result = firstNumb - secondNumb;
            return result;
        }

        private double GetMult(double firstNumb, double secondNumb)
        {
            double result = firstNumb * secondNumb;
            return result;
        }
    }
}
