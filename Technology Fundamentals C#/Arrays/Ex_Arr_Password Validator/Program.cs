using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isBetweenSixAndTenChars = StringLenghtChecker(password);
            bool isOnlyLettersAndDigits = StringCharsChecker(password);
            bool haveAtLeastTwoDigits = DigitCountChecker(password);

            if (isBetweenSixAndTenChars == true && isOnlyLettersAndDigits == true && haveAtLeastTwoDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (isBetweenSixAndTenChars == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (isOnlyLettersAndDigits == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (haveAtLeastTwoDigits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        private static bool StringCharsChecker(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool StringLenghtChecker(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool DigitCountChecker(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
