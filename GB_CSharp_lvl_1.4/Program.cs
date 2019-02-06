using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*  5)  *а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
            Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
            возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального
            элемента массива(через параметры, используя модификатор ref или out).
        **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
        **в) Обработать возможные исключительные ситуации при работе с файлами.
        
        Александр Кушмилов.
*/

namespace GB_CSharp_lvl_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Array2D testArr = new Array2D(3, 3, 0, 100, "D:\\out_lvl_1.4.txt");
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

            testArr.ReadFile("D:\\out_lvl_1.4.txt");
            testArr.Print();
            Console.ReadKey();
        }
    }

}
