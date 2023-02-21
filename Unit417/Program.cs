using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var enc1251 = Encoding.GetEncoding(1251);
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.InputEncoding = enc1251;


        for (int k = 0; k < 3; k++)
        {
            (string FirstName, string LastName, string Login, int LoginLenght, bool HasPet, int Age, string PetName, string[] favcolors) User;

            Console.WriteLine("Введите имя");
            User.FirstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();

            User.LoginLenght = User.Login.Length;

            Console.WriteLine("Есть ли у Вас животное? (Да/Нет)");
            var result = Console.ReadLine();

            if (result == "Да")
            {
                User.HasPet = true;
                Console.WriteLine("Введите имя питомца");
                User.PetName = Console.ReadLine();
            }
            else
            {
                User.HasPet = false;
                User.PetName = null;
            }
            Console.WriteLine("Введите Ваш возраст");
            User.Age = Convert.ToInt32(Console.ReadLine());

            User.favcolors = new string[3];
            Console.WriteLine("Введите Ваши три любимых цвета");
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
        }
    }
}
