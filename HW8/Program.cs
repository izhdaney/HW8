using System;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calcResult = new Calculator();

            //calcResult.firstNumb = calcResult.GetFirstNumb();
            //calcResult.actionValue = calcResult.GetActionValue();
            //calcResult.secondNumb = calcResult.GetSecondNumb();


            //calcResult.result = calcResult.GetResult();

            //Console.WriteLine($"Результат {calcResult.firstNumb} {calcResult.actionValue} {calcResult.secondNumb} = {calcResult.result}");



            MyArray a = new MyArray(5);
            a.NegativeElSum();
            a.PositiveOrNegative();
            a.Average();
            Console.Write("Элементы массива: ");
            for (int i = 0; i < a.Arr.Length; i++)
            {
                Console.Write($"{a.Arr[i]} ");
            }

        }
    }
}
