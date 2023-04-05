using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
