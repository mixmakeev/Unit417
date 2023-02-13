using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Цикл do");
        var i = 0;
        while (i < 5)

        { 
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы или stop для выхода.");
            Console.WriteLine("Iteration {0}", i);
            var text = Console.ReadLine();
            switch (text)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is Red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is Green!");
                    break;

                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is Cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Неверный цвет!");
                    break;

            }
            i++;
                    if (text == "stop")
                    {
                Console.WriteLine("цикл остановлен");

                break;
            }
        } 
    }
}