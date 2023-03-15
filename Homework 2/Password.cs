using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class Password
    {
        public string PasswordString { get; set; }

        public Password(string passwordString)
        {
            
            if(passwordString.Length < 6)
            {
                throw new ArgumentException("Lütfen en az 6 karakter içeren bir şifre oluşturun\n");
            }
            

            //I converted booleans to integers as I will simply add three of them
            //and work with it, in order to see how many of the conditions are satisfied.
            //I am using this approach as we do not need to specify which condition is not satisfied.

            int checkNonAlphanumeric = Convert.ToInt32(this.HasNonAlphanumeric(passwordString));
            int checkNumber = Convert.ToInt32(this.HasDigit(passwordString));
            int checkLetter = Convert.ToInt32(this.HasLetter(passwordString));

            int satisfiedConditionCount = checkNonAlphanumeric + checkNumber + checkLetter;

             
            switch (satisfiedConditionCount)
            {
                case 1:
                    Console.WriteLine("Girdiğiniz şifre ZAYIF");
                    break;
                case 2:
                    Console.WriteLine("Girdiğiniz şifre ORTA");
                    break;
                case 3:
                    Console.WriteLine("Girdiğiniz şifre GÜÇLÜ");
                    break;
                default:
                    //Default case throws an exception, as addition of these three variables can not be anything else
                    throw new Exception("Beklenmeyen bir hata oluştu");
            }
            

            PasswordString = passwordString;
        }

        private bool HasNonAlphanumeric(string passwordString)
        {
            bool nonAlphanumericFlag = false;
            foreach(char c in passwordString)
            {
                bool isNotLetterOrDigit = !(Char.IsLetterOrDigit(c));
                nonAlphanumericFlag = isNotLetterOrDigit ? true : nonAlphanumericFlag;
            }
            return nonAlphanumericFlag;
        }

        private bool HasLetter(string passwordString)
        {
            bool letterFlag = false;
            foreach (char c in passwordString)
            {
                letterFlag = Char.IsLetter(c) ? true : letterFlag;
            }
            return letterFlag;
        }

        private bool HasDigit(string passwordString)
        {
            bool digitFlag = false;
            foreach (char c in passwordString)
            {
                digitFlag = Char.IsDigit(c) ? true : digitFlag;
            }
            return digitFlag;
        }
    }
}
