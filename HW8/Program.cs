using System;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        private static void Task1()
        {
            Calculator n = new Calculator();

            n.firstNumb = n.GetFirstNumb();
            n.actionValue = n.GetActionValue();
            n.secondNumb = n.GetSecondNumb();

            n.GetResult();
        }

        private static void Task2()
        {

            // InsertElement(arr, insertValue); - добавение
            // DeleteElemnt(arr); - удаление последнего элемента
            // SortBubble(arr); - сортировка пузырьком
            // ArrPrint(arr); - печать в консоль
            // ArrClear(arr); - очистка.

            MyArray n = new MyArray();

            n.n = n.GetArrayLength();

            int[] arr = new int[n.n];

            arr = n.GetArray(arr);

            n.ArrPrint(arr);

            // 

            int insertValue = n.GetInsertElement();

            arr = n.InsertElement(arr, insertValue);

            n.ArrPrint(arr);

            //

            arr = n.DeleteElemnt(arr);

            n.ArrPrint(arr);

            //

            arr = n.SortBubble(arr);

            n.ArrPrint(arr);

            //

            arr = n.ArrClear(arr);

            n.ArrPrint(arr);


        }

    }
}
