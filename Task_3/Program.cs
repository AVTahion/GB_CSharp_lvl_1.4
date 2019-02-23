using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

/*  3.  а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера
 *      и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму
 *      элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
 *      метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
        б) ** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
        е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
*/
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray((uint)10, -10, 2);
            Console.WriteLine($"Массив [10] от -10 с шагом 2:                {array.ToString()}");
            MyArray invArray = array.Inverse();
            Console.WriteLine($"Массив полученный методом Inverse:           {invArray.ToString()}");
            array.Multi(3);
            Console.WriteLine($"Массив после домнажения всех эллементов на 3:{array.ToString()}");
            Console.WriteLine($"Кол-во вхождений максимального элемента массива ({array.Max}): {array.MaxCount}");

            MyArray array2 = new MyArray(30, 1, 6);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < 30; i++)
            {
                if (dict.ContainsKey(array2[i])) dict[array2[i]]++;
                else dict.Add(array2[i], 1);
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} шт");
            }
            Console.ReadKey();
        }
    }
}
