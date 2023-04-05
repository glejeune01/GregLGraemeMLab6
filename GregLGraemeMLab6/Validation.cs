using System;
using System.IO;

namespace GregLGraemeMLab6
{
    public class Validation
    {
        public bool ValidateCredentials(UserCreds user, string enteredUsername, string enteredPassword)
        {
            if (user.Username == enteredUsername && user.Password == enteredPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ValidateFile(string filePath)
        {
            // Check if the file path exists
            if (!File.Exists(filePath))
            {
                throw new ArgumentException("File Path does not exist, please check if file is in C:/files");
            }
        }

        public static int IsInteger(string value)
        {
            int result;
            int.TryParse(value, out result);
            return result;
        }

        public static decimal IsDecimal(string value)
        {
            decimal result;
            decimal.TryParse(value, out result);
            return result;
        }
    }
}
