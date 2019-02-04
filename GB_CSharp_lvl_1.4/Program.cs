﻿using System;
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
        /// Свойство возвращающее минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = Arr[0, 0];
                for (int i = 0; i < Arr.GetLength(0); i++)
                {
                    for (int j = 0; j < Arr.GetLength(1); j++)
                    {
                        if (Arr[i, j] < min) min = Arr[i, j];
                    }
                }
                return min;
            }
        }

        /// <summary>
        /// Свойство возвращающее максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = Arr[0, 0];
                for (int i = 0; i < Arr.GetLength(0); i++)
                {
                    for (int j = 0; j < Arr.GetLength(1); j++)
                    {
                        if (Arr[i, j] > max) max = Arr[i, j];
                    }
                }
                return max;
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

        /// <summary>
        /// Метод возвращает сумму всех элементов массива
        /// </summary>
        /// <returns></returns>
        public long Sum()
        {
            long sum = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    sum += Arr[i,j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Метод возвращает сумму всех элементов массива больше заданного
        /// </summary>
        /// <param name="min"></param>
        /// <returns></returns>
        public long Sum(int min)
        {
            long sum = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Arr[i,j] > min) sum += Arr[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Метод возвращающий индекс максимального элемента массива
        /// </summary>
        /// <param name="indexI"></param>
        /// <param name="indexJ"></param>
        public void IndexOfMax(out int indexI, out int indexJ)
        {
            int max = Max;
            indexI = 0;
            indexJ = 0;

            //Реализация проходит весь массив и выдает индекс последнего из максимальных элементов если их несколько
            //for (int i = 0; i < Arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr.GetLength(1); j++)
            //    {
            //        if (Arr[i, j] == max)
            //        {
            //            indexI = i;
            //            indexJ = j;
            //        }
            //    }
            //}

            //Реализация выдает индекс первого найденного максимального элемента массива
            int i = 0;
            while (indexI == 0 && i < Arr.GetLength(0) && indexJ == 0)
            {
                int j = 0;
                while (indexJ == 0 && j < Arr.GetLength(1))
                {
                    if (Arr[i, j] == max)
                    {
                        indexI = i;
                        indexJ = j;
                    }
                    j++;
                }
                i++;

            } 
        }


    }


        

    class Program
    {
        static void Main(string[] args)
        {
            Array2D testArr = new Array2D(3, 3, 0, 100);
            testArr.Print();
            Console.WriteLine();
            Console.WriteLine($"Сумма всех элементов массива = {testArr.Sum()}");
            Console.WriteLine();
            int min = 70;
            Console.WriteLine($"Сумма всех элементов больше {min} равна: {testArr.Sum(min)}");
            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент массива: {testArr.Min}");
            Console.WriteLine();
            int i = 0;
            int j = 0;
            testArr.IndexOfMax(out i, out j);
            Console.WriteLine($"Максимальный элемент массива: {testArr.Max}, с индексом [{i},{j}]");
            Console.WriteLine();
            Console.ReadKey();
        }
    }

}
