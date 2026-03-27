using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint nechet = 0;
            uint chet = 0;
            Console.WriteLine("Введите первое число диапозона");
            int currentValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее число диапозона");
            int limit = int.Parse(Console.ReadLine());
            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    chet++;
                }
                else
                {
                    nechet++;
                }
                currentValue++;
            }
            Console.WriteLine("Количество нечётных чисел: " + nechet);
            Console.WriteLine("Количество чётных чисел: " + chet);
            Console.ReadLine();
        }
    }
}
