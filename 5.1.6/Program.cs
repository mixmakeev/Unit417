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


    static int[] SortArrayAsc(int[] result)
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
    static int[] SortArrayDesc(int[] result)
    {
        int temp = 0;
        for (int n = 0; n < result.Length; n++)
            for (int j = n + 1; j < result.Length; j++)
                if (result[n] < result[j])
                {
                    temp = result[n];
                    result[n] = result[j];
                    result[j] = temp;
                }
        return result;
    }

    static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedask)
    {
        sortedask = SortArrayAsc(array);
        sorteddesc = SortArrayDesc(array);
        foreach (var item in sortedask)
        {
            Console.WriteLine(item);
        }
        foreach (var item1 in sorteddesc)
        {
            Console.WriteLine(item1);
        }
    }
/*    static void ShowArray(int[] array, bool IsSort = false)
    {
        var tempsort = array;
        if (IsSort)
        {
            tempsort= SortArray(array);
        }

        foreach (var item in tempsort)
        {
            Console.WriteLine(item);
        }
    }  
*/
    static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var enc1251 = Encoding.GetEncoding(1251);
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.InputEncoding = enc1251;
        Console.WriteLine("привет, введите размер массива");
        int num = Convert.ToInt32(Console.ReadLine());
        var array = GetArrayFromConsole(num);
        var tempsort = array;
        SortArrayAsc(array);


        /*ShowArray(array, false);*/

    }
}