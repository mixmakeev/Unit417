using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text;

class MainClass
{
    static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var enc1251 = Encoding.GetEncoding(1251);
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.InputEncoding = enc1251;

        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");
        var deep = int.Parse(Console.ReadLine());

        Echo(str, deep);

        Console.ReadKey();
    }

    static void Echo(string str, int deep)
    {
        var modif = str;

        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }

        if (deep < 16)
        {
            Console.BackgroundColor = (ConsoleColor)deep;
        }

        Console.WriteLine(". . ." + modif);

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }

    }


}