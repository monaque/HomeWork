using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"Привет, {name}. Сегодня {date}.");
        }
    }
}
