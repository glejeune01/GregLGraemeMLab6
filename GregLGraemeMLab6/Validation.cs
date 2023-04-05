using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
