using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class PasswordGenerator
    {
        private static readonly Random random = new Random();

        public static string GeneratePassword(int length, bool includeDigits, bool includeSymbols)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string symbols = "!@#$%^&*()_-+=[]{}\\|;:'\",.<>/?";

            var passwordChars = new char[length];
            int charIndex = 0;

            for (int i = 0; i < length; i++)
            {
                string charPool = chars;

                if (includeDigits && i % 3 == 0)
                {
                    charPool += digits;
                }

                if (includeSymbols && i % 5 == 0)
                {
                    charPool += symbols;
                }

                passwordChars[charIndex++] = charPool[random.Next(charPool.Length)];
            }

            string password = new string(passwordChars);
            string hiddenPassword = new string('*', length);

            Console.WriteLine("Вы успешно сгенерировали пароль:");
            Console.WriteLine($"Пароль: {hiddenPassword}");
            Console.WriteLine($"Длина пароля: {length}");
            Console.WriteLine($"Содержит цифры: {(includeDigits ? "Да" : "Нет")}");
            Console.WriteLine($"Содержит символы: {(includeSymbols ? "Да" : "Нет")}");

            return password;
        }
    }
}
