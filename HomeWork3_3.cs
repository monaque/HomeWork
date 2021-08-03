using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson_3.HomeWork_3
{
    class HomeWork3_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для переворачивания слов =) Введите что-либо:");
            string str = Console.ReadLine();
            Console.WriteLine("Наоборот: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();

        }
    }
}
