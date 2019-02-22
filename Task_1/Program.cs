using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1)  Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
 *      Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых 
 *      только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива 
 *      из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
*/

namespace Task_1
{
    class Program
    {
        /// <summary>
        /// Метод подсчитывает количество пар чисел в массиве в которых только одно число делиться на 3.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int CheckPairs(int[] array)
        {
            int amount = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] % 3 == 0 ^ array[i] % 3 == 0)
                {
                    amount++;
                }
            }

            return amount;
        }

        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }
            int x = CheckPairs(array);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
