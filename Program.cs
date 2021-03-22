using System;
using NumberSystem;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число:   ");
            string mainString = Console.ReadLine();

            Console.WriteLine("Введите начальную систему счисления:   ");
            int firstSystem = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите конечную систему счисления:   ");
            try
            {
                int secondSystem = Convert.ToInt32(Console.ReadLine());
                char[] result = translateNumbers.translateMain(mainString, firstSystem, secondSystem);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Некорректный ввод.");
            }      
        }
    }
}
