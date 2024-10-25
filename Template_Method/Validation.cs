using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal abstract class Validation
    {
        public bool Validate(string _string)
        { 
            bool result = 
                LenghtValidate(_string)         && 
                NumberValidate(_string)         && 
                CapitalCharValidate(_string)    && 
                SpecialSymbolValidate(_string);
            return result;
        }
        public virtual bool LenghtValidate(string _string) { return true; }
        public virtual bool NumberValidate(string _string) { return true; }
        public virtual bool CapitalCharValidate(string _string) { return true; }
        public virtual bool SpecialSymbolValidate(string _string) { return true; }
    }
}
