using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5_3
{
    internal class MyArray
    {
        private List<int> Array;

        public MyArray(int size)
        {
            Array = new List<int>();
            Console.WriteLine("\nВведите элементы массива.");
            var stElems = Console.ReadLine()?.Split(' ');
            if (stElems != null)
                foreach (var stElem in stElems)
                    Array.Add(Convert.ToInt32(stElem));
        }

        public int this[int i]
        {
            get { return Array[i]; }
            set { Array[i] = value; }
        }

        public void Delete() => Array = null;

        public override string ToString()
        {
            var str = Array.Aggregate("", (current, i) => current + Convert.ToString(i) + " ");
            return str;
        }

        ~MyArray()
        {
            Console.WriteLine("Массив был удалён.");
        }
    }

    class Test
    {
        static void Main()
        {
            Console.WriteLine("Введите количество элементов массива.");
            var size = Convert.ToInt32(Console.ReadLine());
            var array = new MyArray(size);
            Console.Clear();
            Console.WriteLine("Введённый массив: {0}", array);
            try
            {
                Console.WriteLine("\n{0} элемент массива:", size + 1);
                Console.WriteLine(array[size+1]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка! Аргумент вышел за пределы массива.");
            }
            finally
            {
                array.Delete();
            }
            Console.ReadKey();
        }
    }
}
