using System;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calcResult = new Calculator();

            calcResult.firstNumb = calcResult.GetFirstNumb();
            calcResult.actionValue = calcResult.GetActionValue();
            calcResult.secondNumb = calcResult.GetSecondNumb();


            calcResult.GetResult();

        }
    }
}
