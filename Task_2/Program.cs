using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*  2.  Реализуйте задачу 1 в виде статического класса StaticClass;
        а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
        в)**Добавьте обработку ситуации отсутствия файла на диске.
*/

namespace Task_2
{
    public static class StaticClass
    {
        /// <summary>
        /// Метод подсчитывает количество пар чисел в массиве в которых только одно число делиться на 3.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int CheckPairs(int[] array)
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

        /// <summary>
        /// Метод считывает массив целых чисел из текстового файла
        /// </summary>
        /// <param name="pathToFile"></param>
        /// <returns></returns>
        static int[] ReadFile(string pathToFile)
        {
            try
            {
                string text = File.ReadAllText(pathToFile);
                string[] textArr = text.Split(' ');    //разбиение на массив с разделением по пробелу
                int[] testInt = new int[textArr.Length];

                for (int i = 0; i < textArr.Length; i++)
                {
                    int x = 0;
                    Int32.TryParse(textArr[i], out x);
                    testInt[i] = x;
                }
                return testInt;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }
            int x = StaticClass.CheckPairs(array);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
