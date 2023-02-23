using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        /* Без перекодирования не отображается кириллица в консоли. */
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var enc1251 = Encoding.GetEncoding(1251);
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.InputEncoding = enc1251;
        /* Без перекодирования не отображается кириллица в консоли. */

        Console.WriteLine("Привет");
        ShowUserData();        
         
    }

    static void ShowUserData() //Метод вывода информации о пользователе
    {
        var tempsort = UserData();
        Console.WriteLine("_____________________________________________________________________________________");
        Console.WriteLine("Информация о введённых данных:");
        Console.WriteLine("Ваше имя: {0},\nВаша фамилия: {1},\nВаш возраст: {2}", tempsort.FirstName, tempsort.LastName, tempsort.Age);
        if (tempsort.arraypet != null)
        {
            var arrayp = tempsort.arraypet;
            Console.WriteLine("________________________");
            Console.WriteLine("Ваши животные:");
            foreach (var item in arrayp)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Животных нет.");
        }
        var arraycol = tempsort.arraycolors;
        Console.WriteLine("________________________");
        Console.WriteLine("Ваши цвета:");
        foreach (var item in arraycol)
        {
            Console.WriteLine(item);
        }

    }
    static string[] CreateArrayPets(int PetAmound) //Метод ввода кличек домашних животных
    {
        var result = new string[PetAmound];
        for (int n = 0; n < result.Length; n++)
        {
            Console.WriteLine("Введите кличку животного номер {0}", n + 1);
            result[n] = Console.ReadLine();
        }
        return result;
    }
    static string[] CreateArrayColors(int ColorsAmound) //Метод ввода любимых цветов
    {
        string[] favcolors = new string[ColorsAmound];
        Console.WriteLine("Введите Ваши любимые цвета");
        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = Console.ReadLine();
        }
        return favcolors;
    }

    static bool CheckNum(string number, out int corrnumber)
    {
       
        if (int.TryParse(number, out int intnum))
        {
          if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }
        corrnumber= 0;
        return true;
    }//Метод проверки значение на 0



    static (string FirstName, string LastName, int Age, string[] arraypet, string[] arraycolors) UserData() //Метод сбора данных о пользователе
    {
        (string FirstName, string LastName, int Age, string[] arraypet, string[] arraycolors) User;
        
        Console.WriteLine("Введите имя");
        User.FirstName = Console.ReadLine();

        Console.WriteLine("Введите фамилию");
        User.LastName = Console.ReadLine();

        string age;
        int intage;
        do
        {
            Console.WriteLine("Введите Ваш возраст");
            age = Console.ReadLine();
        }
        while (CheckNum(age, out intage));

        User.Age = intage;

        Console.WriteLine("Есть ли у Вас животное? (Да/Нет)");
        var result = Console.ReadLine();

        if (result == "Да")
        {
            string PetAmo;
            int intPetAmound;
            do
            {
                Console.WriteLine("Введите количество ваших животных:");
                PetAmo = Console.ReadLine();
            }
            while (CheckNum(PetAmo, out intPetAmound));

            int PetAmound = intPetAmound;

            User.arraypet = CreateArrayPets(PetAmound);
        }
        else User.arraypet = null;

        string ColorAmo;
        int intColorAmmound;
        do
        {
            Console.WriteLine("Введите количество любимых цветов:");
            ColorAmo = Console.ReadLine();
        }
        while (CheckNum(ColorAmo, out intColorAmmound));

        int ColorsAmound = intColorAmmound;
        User.arraycolors = CreateArrayColors(ColorsAmound);

        return User;

    }
    
        
}