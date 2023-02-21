using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text;

class Program
{
    static int[] GetArrayFromConsole(int num=5)
    {
        
        var result = new int[num];

        for (int n = 0; n < result.Length; n++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", n + 1);
            result[n] = int.Parse(Console.ReadLine());
        }
        return result;
    }

    static int[] SortArray(int[] result)
    {
        int temp = 0;
        for (int n = 0; n < result.Length; n++)
            for (int j = n + 1; j < result.Length; j++)
                if (result[n] > result[j])
                {
                    temp = result[n];
                    result[n] = result[j];
                    result[j] = temp;
                }
        return result;
    }

    static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var enc1251 = Encoding.GetEncoding(1251);
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.InputEncoding = enc1251;
        Console.WriteLine("привет");
        var array = GetArrayFromConsole(3);
        var sort = SortArray(array);
        for (int e = 0; e < sort.Length; e++)
        {
            Console.WriteLine(sort[e]);
        }
        Console.ReadKey();
    }
}