using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text;


class Program
{
    static string ShowColor()
    {
          Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
          var color = Console.ReadLine();

          switch (color)
          {
              case "red":
                  Console.BackgroundColor = ConsoleColor.Red;
                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.WriteLine("Your color is red!");
                  break;

              case "green":
                  Console.BackgroundColor = ConsoleColor.Green;
                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.WriteLine("Your color is green!");
                  break;
              case "cyan":
                  Console.BackgroundColor = ConsoleColor.Cyan;
                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.WriteLine("Your color is cyan!");
                  break;
              default:
                  Console.BackgroundColor = ConsoleColor.Yellow;
                  Console.ForegroundColor = ConsoleColor.Red;

                  Console.WriteLine("Your color is yellow!");
                  break;
          }
          return color;
     
    }
 
    static void Main(string[] args)
    {
          Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
          var enc1251 = Encoding.GetEncoding(1251);
          System.Console.OutputEncoding = System.Text.Encoding.UTF8;
          System.Console.InputEncoding = enc1251;

          (string Name, string[] Dishes) User;
          Console.WriteLine("Введите имя");
          User.Name = Console.ReadLine();

          User.Dishes = new string[5];
          var favcolors = new string[3];

          for (int i = 0; i < User.Dishes.Length; i++)
          {
              Console.WriteLine("Введите любимое блюдо номер {0}", i + 1);
              User.Dishes[i] = Console.ReadLine();
          }
          ShowColor();
          for (int k = 0; k < favcolors.Length; k++)
          {
              favcolors[k] = ShowColor();
          }
          Console.WriteLine("Ваши любимые цвета:");
          foreach (var color in favcolors)
          {
              Console.WriteLine(color);
          }

          Console.ReadKey();
    }
     
   
}


