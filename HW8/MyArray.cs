using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class MyArray
    {
        public MyArray()
        {
            n = GetArrayLength();
            int[] arr = new int[n];
            GetArray(arr);
        }
        public int n;

        

        public int GetArrayLength()
        {
            int returnValue;
            Console.WriteLine("Пожалуйста, введите длинну массива, значеие > 1");
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
            n = returnValue;
            return n;
        }
        
        public int[] GetArray(int[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 50);
            }

            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }

                return arr;
        }

    }
}
