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
        for (int i = 1; i > 0; i++)
        {
            Console.WriteLine("Введите число для расчета или -1 для выхода:");

            int x = Convert.ToInt32(Console.ReadLine());
            if (x == -1)
            {
                Console.WriteLine("Окончание цикла");
                break;
            }
            var y = Factorial(x);
            Console.WriteLine("Факториал числа {0} равен {1}", x, y);
        }
        Console.ReadKey();
    }

    static decimal Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }
 /*   private static int PowerUp(int N, byte pow)
    {

        if (pow == 0)
        {
             return  1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp (N, --pow);
            }
        }
       
    }
 */

}