using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text;


class Program
{
    static string ShowName (string username, string userage)
    {
        Console.WriteLine("{0}, Ваш возраст {1}.\nнапишите свой любимый цвет: ", username, userage);
        var colors = Console.ReadLine();

        switch (colors)
        {
            case "Красный":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("{0}, ваш возраст {1}\nВаш цвет Красный!", username, userage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                break;

            case "красный":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("{0}, ваш возраст {1}\nВаш цвет Красный!", username, userage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                break;

            case "Зеленый":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("{0}, ваш возраст {1}\nВаш цвет Зеленый!", username, userage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                break;

            case "зеленый":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("{0}, ваш возраст {1}\nВаш цвет Зеленый!", username, userage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                break;

            case "бирюзовый":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("{0}, ваш возраст {1}\nВаш цвет Бирюзовый!", username, userage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                break;

            case "Бирюзовый":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("{0}, ваш возраст {1}\nВаш цвет Бирюзовый!", username, userage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                break;

            case "Синий":
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("{0}, ваш возраст {1}\nВаш цвет Синий!", username, userage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                break;

            case "синий":
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("{0}, ваш возраст {1}\nВаш цвет Синий!", username, userage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("{0}, ваш возраст {1}\nВаш цвет Желтый!", username, userage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
        return colors;

    }



    static void Main (string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var enc1251 = Encoding.GetEncoding(1251);
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.InputEncoding = enc1251;


        (string name, int age) anketa;

        Console.Write("Введите имя: ");
        anketa.name = Console.ReadLine();
        Console.Write("{0}, ведите возраст цифрами: ", anketa.name);
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя {0}", anketa.name);
        Console.WriteLine("Ваш возраст {0}", anketa.age);

        var temp = new string[3];
        string tempage = Convert.ToString(anketa.age);

        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = ShowName(anketa.name, tempage);
        }
        Console.WriteLine("Ваши любимые цвета:");
        foreach (var usercolors in temp) 
        {
            Console.WriteLine(usercolors);
        }
        Console.ReadKey();
    }
}