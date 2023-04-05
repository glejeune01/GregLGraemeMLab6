using System;
using System.IO;
using System.Windows.Forms;

namespace GregLGraemeMLab6
{
    public class FileHandler
    {
        public static Book[] ImportBooks(string filePath)
        {
            try
            {
                Validation.ValidateFile(filePath);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error - Import Failed");

                return null;
            }

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
                            book = new NonFiction { Stock = Validation.IsInteger(fields[5]) };
                        }
                        else if (fields[3] == "Fiction")
                        {
                            book = new Fiction { Stock = Validation.IsInteger(fields[5]) };
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (fields.Length == 7 && fields[3] == "ComicBook") // ComicBook
                    {
                        book = new ComicBook { Edition = fields[5], Stock = Validation.IsInteger(fields[6]) };
                    }
                    else
                    {
                        continue;
                    }
                    book.Code = Validation.IsInteger(fields[0]);
                    book.Title = fields[1];
                    book.Author = fields[2];
                    book.Genre = fields[3];
                    book.Price = Validation.IsDecimal(fields[4]);

                    Array.Resize(ref Program.bookArray, Program.bookArray.Length + 1);
                    Program.bookArray[Program.bookArray.Length - 1] = book;
                }
                foreach (Book book in Program.bookArray)
                {
                    if (book is ComicBook comicBook)
                    {
                        ComicBook clonedComicBook = (ComicBook)comicBook.Clone();
                        Array.Resize(ref Program.bookArray, Program.bookArray.Length + 1);
                        Program.bookArray[Program.bookArray.Length - 1] = clonedComicBook;
                    }
                }


                return Program.bookArray;
            }
        }


        public static UserCreds[] ImportUsers(string filePath)
        {
            UserCreds[] userArray = new UserCreds[0];
            try
            {
                Validation.ValidateFile(filePath);
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
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error - no file");
                Environment.Exit(1);
            }
            return userArray;
        }



        public static void ExportBooks(string filePath, Book[] books)
        {
            try
            {
                Validation.ValidateFile(filePath);

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
                            line = $"{book.Code}|{book.Title}|{book.Author}|{book.Genre}|{book.Price}|{(book as ComicBook).Edition}|{book.Stock}";
                        }
                        else
                        {
                            line = $"{book.Code}|{book.Title}|{book.Author}|{book.Genre}|{book.Price}|{book.Stock}";
                        }
                        writer.WriteLine(line);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error - Export Failed");
            }
        }


    }
}
