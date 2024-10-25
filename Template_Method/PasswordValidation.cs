using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class PasswordValidation : Validation
    {
        public override bool LenghtValidate(string _string) 
        {
            if (_string.Length > 7) { return true; }
            else
            {
                Console.WriteLine($"Длина имени должна быть минимум 8 символов\n");
                return false;
            }
        }
        public override bool NumberValidate(string _string) 
        {
            if (Regex.IsMatch(_string, @".*\d+.*")) { return true; }
            else
            {
                Console.WriteLine($"Пароль должен содержать хотя бы одну цифру\n");
                return false;
            }
        }
        public override bool CapitalCharValidate(string _string) 
        {
            if (Regex.IsMatch(_string, @".*[A-Z]|[А-Я]+.*")) { return true; }
            else
            {
                Console.WriteLine($"Пароль должен содержать хотя бы одну залавную букву\n");
                return false;
            }
        }
        public override bool SpecialSymbolValidate(string _string) 
        {
            if (Regex.IsMatch(_string, @".*[-!#\$%&'\*\+/=\?\^`\{\}\|~]+.*")) { return true; }
            else
            {
                Console.WriteLine($"Пароль должен содержать спец символ\n");
                return false;
            }
        }
    }
}
