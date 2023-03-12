using System;

namespace Hello
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.Write("Ваше имя? ");
            string name = Console.ReadLine();
            Console.WriteLine("Здорова, " + name + "!");
        }
    }
}