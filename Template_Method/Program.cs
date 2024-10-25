using System.Text.RegularExpressions;

namespace Template_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Имя должно содержать только буквы и быть формата: \"Иван\"");
            Console.Write($"Введите имя для валидации: ");
            string nameString = Console.ReadLine();
            NameValidation nameValidation = new NameValidation();

            if (nameValidation.Validate(nameString))
            {
                Console.WriteLine($"Имя подходит");
            }
            else
            {
                Console.WriteLine($"Имя не подходит");
            }
            Console.WriteLine();

            Console.WriteLine($"Пароль должен содержать заглавные буквы, цифры и спец символы. Пример пароля: \"!1Qwerty\"");
            Console.Write($"Введите пароль для валидации: ");
            string passString = Console.ReadLine();
            PasswordValidation passValidation = new PasswordValidation();

            if (passValidation.Validate(passString))
            {
                Console.WriteLine($"Пароль подходит");
            }
            else 
            {
                Console.WriteLine($"Пароль не подходит");  
            }
        }
    }
}
