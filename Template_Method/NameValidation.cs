using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class NameValidation : Validation
    {
        public override bool CapitalCharValidate(string _string)
        {
            if (Regex.IsMatch(_string, @"^[A-Z]|[А-Я]{1}[a-z]|[а-я]+$")) { return true; }
            else if (Regex.IsMatch(_string, @"^[A-Z]|[А-Я]{1}[a-z]|[а-я]+")) 
            {
                Console.WriteLine($"Имя должно содержать только буквы\n");
                return false; 
            }
            else
            {
                Console.WriteLine($"Все символы кроме первого должны быть строчными\n");
                return false;
            }
        }
        public override bool LenghtValidate(string _string)
        {
            if (_string.Length > 2) { return true; }
            else 
            {
                Console.WriteLine($"Длина имени должна быть минимум 3 символов\n");
                return false;
            }
        }
        public override bool NumberValidate(string _string)
        {
            if (!Regex.IsMatch(_string, @".*\d+.*")) { return true; }
            else
            {
                Console.WriteLine($"В имени не должно быть цифр\n");
                return false;
            }
        }
    }
}
