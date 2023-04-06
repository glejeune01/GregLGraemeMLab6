using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregLGraemeMLab6
{
    internal class Program
    {
        //declaring two empty arrays we reference all over the program
        public static Book[] bookArray = new Book[0];
        public static UserCreds[] userArray = new UserCreds[0];


        static void Main(string[] args)
        {
            //running the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}