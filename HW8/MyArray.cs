using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class MyArray
    {

        public int n;

        public int GetArrayLength()
        {
            int returnValue;
            Console.WriteLine("Please enter the length of the array, the value > 1\n");
            do
            {
                string readValue = Console.ReadLine();
                int.TryParse(readValue, out returnValue);
                if (returnValue > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное значение. Попроуйте еще раз");
                }

            } while (true);

            return returnValue;
        }
        
        public int[] GetArray(int[] arr)
        {
            Console.WriteLine("Created an array:\n");
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 50);
            }
                return arr;
        }

        public int GetInsertElement()
        {
            Console.WriteLine("Please enter the value of the array element you want to add\n");
            int returnValue;
            do
            {
                string readValue = Console.ReadLine();
                
                if (int.TryParse(readValue, out returnValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered the wrong value. Try again\n");
                }

            } while (true);
            return returnValue;

        }

        public int[] InsertElement(int[] arr, int insertValue)
        {
            Console.WriteLine($"Element {insertValue} is added to the end of the array.\n");

            int[] newArr = new int[arr.Length + 1];

            newArr[arr.Length] = insertValue;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }

        public int[] DeleteElemnt(int[] arr)
        {
            Console.WriteLine("Deleting the last item\n");
            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }

        public int[] SortBubble(int[] arr)
        {
            Console.WriteLine("Sorting an array using the bubble method\n");

            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        public void ArrPrint(int[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine("\n");
        }

        public int[] ArrClear(int[] arr)
        {
            Array.Clear(arr, 0, arr.Length);
            return arr;
        }

    }
}
