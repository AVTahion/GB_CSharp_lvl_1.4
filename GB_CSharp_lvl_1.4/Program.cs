using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  5)  *а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
            Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
            возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального
            элемента массива(через параметры, используя модификатор ref или out).
        **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
        **в) Обработать возможные исключительные ситуации при работе с файлами.
*/

namespace GB_CSharp_lvl_1._4
{
    /// <summary>
    /// Класс для работы с двумерным массивом.
    /// </summary>
    class Array2D
    {
        int[,] Arr;

        public int[,] Arr1 { get => Arr; set => Arr = value; }

        /// <summary>
        /// Конструктор заполняющий массив [a,b] случайными числами из заданного диапозона 
        /// </summary>
        /// <param name="a">кол-во строк массива</param>
        /// <param name="b">кол-во столбцов массива</param>
        /// <param name="min">минимальное значение</param>
        /// <param name="max">максимальное значение</param>
        public Array2D(int a, int b, int min, int max)
        {
            Arr = new int[a, b];
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Arr[i, j] = rnd.Next(min, max);
                }
            }
        }

        /// <summary>
        /// Метод выводит массив в консоль
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write($"{Arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Array2D testArr = new Array2D(5, 7, 0, 100);
            testArr.Print();
            Console.ReadKey();
        }
    }

}
