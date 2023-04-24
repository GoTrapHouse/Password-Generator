using System;
namespace ConsoleApp1;
class Program
{

    public static void Main()
    {
        Console.WriteLine("Вы запустили генератор пароля\nBy TrapHouse");


        int length;
        while (true)
        {
            Console.Write("Введите длину пароля: ");
            if (int.TryParse(Console.ReadLine(), out length))
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }

        Console.Write("Включить цифры? (да/нет): ");
        bool includeDigits = Console.ReadLine().ToLower() == "да";

        Console.Write("Включить символы? (да/нет): ");
        bool includeSymbols = Console.ReadLine().ToLower() == "да";

        string password = PasswordGenerator.GeneratePassword(length, includeDigits, includeSymbols);

        Console.Write("Показать пароль? (да/нет): ");
        bool showPassword = Console.ReadLine().ToLower() == "да";

        if (showPassword)
        {
            Console.WriteLine($"Пароль: {password}");
        }
        
        Console.WriteLine("Благодарю вас, за то что воспользовались моим генератором)");
    }
}
