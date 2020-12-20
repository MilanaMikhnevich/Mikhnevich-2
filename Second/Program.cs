using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация списка строк c погодой
            List<string> Wether = new List<string>() { "солнечная", "пасмурная", "дождливая" };
            DateTime date = DateTime.Now;
            Console.Write("Сейчас {0:%h} часов ", date);
            int hour = date.Hour;
            if(hour < 6 || hour > 22)
                Console.Write("ночи.");
            else if(hour < 10)
                Console.Write("утра.");
            else if(hour < 15)
                Console.Write("дня.");
            else
                Console.Write("вечера.");
            int index = (new Random()).Next(0, 3);
            Console.Write($" Погода {Wether[index]}.");
            Console.ReadKey();

        }
    }
}
