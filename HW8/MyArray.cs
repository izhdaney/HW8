using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class MyArray
    {
        int n;
        Random rnd = new Random();
        public bool IsValidN(int n)
        {
            if (n > 0 && n < 101)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if (!IsValidN(n))
                    throw new ArgumentException("N вне разрешенных пределов!", "value");
                value = n;
            }
        }
        public int[] Arr { get; set; }
        public MyArray(int n)
        {
            if (!IsValidN(n))
                throw new ArgumentException("N вне разрешенных пределов!", "value");
            this.n = n;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-5, 5);
            }
            Arr = array;
        }

        //во всех методах применяем LINQ
        //метод для вычисления суммы всех отрицательных значений
        public void NegativeElSum()
        {
            Console.WriteLine($"Сумма отрицательных элементов: {Arr.Where(x => x < 0).Sum()}");
        }

        //метод ля сравнения количества отрицательных и положительных элементов
        public void PositiveOrNegative()
        {
            var positiveEl = Arr.Where(x => x > 0).Count();
            var negativeEl = Arr.Where(x => x < 0).Count();
            //var zeroEl = Arr.Where(x => x == 0).Count();
            int res = positiveEl - negativeEl;
            if (res > 0)
            {
                Console.WriteLine($"Положительных элементов больше на {Math.Abs(res)}");
            }
            else if (res < 0)
            {
                Console.WriteLine($"Положительных элементов меньше на {Math.Abs(res)}");
            }
            else
            {
                Console.WriteLine($"Положительных и отрицательных элементов поровну");
            }
        }

        //метод для расчета средней
        public void Average()
        {
            Console.WriteL
    }
}
