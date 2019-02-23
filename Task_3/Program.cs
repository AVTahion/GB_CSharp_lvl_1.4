using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  3.  а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера
 *      и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму
 *      элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
 *      метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
        б) ** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
        е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
*/
namespace Task_3
{
    class MyArray
    {
        int[] a;

        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int i in a)
                {
                    sum += i;
                }
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int count = 0;
                int max = a.Max();
                foreach(int x in a)
                {
                    if (x == max) count++;
                }
                return count;
            }
        }

        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }

        /// <summary>
        /// Конструктор создающий массив заданного размера с заданным первым элементом и заполняющий массив числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="n">Размер массива</param>
        /// <param name="a0">Значение первого элемента</param>
        /// <param name="step">Шаг</param>
        public MyArray(uint n, int a0, int step)
        {
            a = new int[n];
            a[0] = a0;
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + step;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

        /// <summary>
        /// Метод создает новый массив с измененными знаками у всех элементов, переданного массива 
        /// </summary>
        /// <returns></returns>
        public int[] Inverse()
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = -a[i];
            }
            return b;
        }

        /// <summary>
        /// Метод умножает каждый элемент массива на x
        /// </summary>
        /// <param name="x">множитель</param>
        public void Multi(int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= x;
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
