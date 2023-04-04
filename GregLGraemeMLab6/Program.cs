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
        public static Book[] bookArray = new Book[0];
        public static UserCreds[] userArray = new UserCreds[0];

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        //Importing the existing list of books
        public static Book[] ImportBooks(string filePath)
        {
            // Open the text file for reading
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read each line of the file and create a book instance for each line
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split('|');

                    // Determine the type of book and create a corresponding instance
                    Book book;
                    if (fields.Length == 6) // NonFiction or Fiction
                    {
                        if (fields[3] == "NonFiction")
                        {
                            book = new NonFiction { Stock = int.Parse(fields[5]) };
                        }
                        else if (fields[3] == "Fiction")
                        {
                            book = new Fiction { Stock = int.Parse(fields[5]) };
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (fields.Length == 7 && fields[3] == "ComicBook") // ComicBook
                    {
                        book = new ComicBook { Edition = fields[5], Stock = int.Parse(fields[6]) };
                    }
                    else
                    {
                        continue;
                    }
                    book.Code = int.Parse(fields[0]);
                    book.Title = fields[1];
                    book.Author = fields[2];
                    book.Genre = fields[3];
                    book.Price = decimal.Parse(fields[4]);

                    Array.Resize(ref bookArray, bookArray.Length + 1);
                    bookArray[bookArray.Length - 1] = book;
                }
                return bookArray;
            }
        }

        public static UserCreds[] ImportUsers(string filePath)
        {
            UserCreds[] userArray = new UserCreds[0];
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read each line of the file and create a book instance for each line
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split('|');

                    // Determine the type of book and create a corresponding instance
                    UserCreds user = null;
                    if (fields.Length == 3)
                    {
                        string username = fields[0];
                        string password = fields[1];
                        string group = fields[2];

                        user = new UserCreds(username, password, group);
                    }
                    if (user != null)
                    {
                        Array.Resize(ref userArray, userArray.Length + 1);
                        userArray[userArray.Length - 1] = user;
                    }
                }
            }
            return userArray;
        }

        public static void ExportBooks(string filePath, Book[] books)
        {
            //Clear contents of file
            File.WriteAllText(filePath, string.Empty);
            // Open the text file for writing
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                // Write each book to the file in the same format as the ImportBooks method reads it
                foreach (Book book in books)
                {
                    string line;
                    if (book is ComicBook)
                    {
                        line = $"{book.Code}|{book.Title}|{book.Author}|ComicBook|{book.Genre}|{(book as ComicBook).Edition}|{book.Price}|{book.Stock}";
                    }
                    else
                    {
                        line = $"{book.Code}|{book.Title}|{book.Author}|{book.Genre}|{book.Price}|{book.Stock}";
                    }
                    writer.WriteLine(line);
                }
            }
        }
    }
}