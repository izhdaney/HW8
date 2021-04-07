using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Calculator
    {

        private static void Task7()
        {
            Console.WriteLine("Please Enter first number");
            if (double.TryParse(Console.ReadLine(), out double firstNumb))
            {
                Console.WriteLine("Please select an action (+, -, /, *)");
                if (char.TryParse(Console.ReadLine(), out char actionValue))
                {
                    Console.WriteLine("Please Enter second number");
                    if (double.TryParse(Console.ReadLine(), out double secondNumb))
                    {
                        double result = 0;
                        switch (actionValue)
                        {
                            case '+':
                                result = getSumTask7(firstNumb, secondNumb);
                                Console.WriteLine($"Result is {result}");
                                break;
                            case '-':
                                result = getSubTask7(firstNumb, secondNumb);
                                Console.WriteLine($"Result is {result}");
                                break;
                            case '/':

                                if (secondNumb == 0)
                                {
                                    Console.WriteLine("Wrong input. Please try again.");
                                }
                                else
                                {
                                    result = getDivTask7(firstNumb, secondNumb);
                                    Console.WriteLine($"Result is {result}");
                                }
                                break;
                            case '*':
                                result = getMultTask7(firstNumb, secondNumb);
                                Console.WriteLine($"Result is {result}");
                                break;
                            default:
                                Console.WriteLine("Wrong input action. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Wrong input. Please try again.");
            }


            Console.WriteLine("Do you want to try again? Enter Y to continue or any key to exit.");
            string value = Convert.ToString(Console.ReadLine());
            if (value == "y")
            {
                Task7();
            }


        }

        private static double getSumTask7(double firstNumb, double secondNumb)
        {
            double result = firstNumb + secondNumb;
            return result;
        }

        private static double getDivTask7(double firstNumb, double secondNumb)
        {
            double result = firstNumb / secondNumb;
            return result;
        }

        private static double getSubTask7(double firstNumb, double secondNumb)
        {
            double result = firstNumb - secondNumb;
            return result;
        }

        private static double getMultTask7(double firstNumb, double secondNumb)
        {
            double result = firstNumb * secondNumb;
            return result;
        }

    }
}
