using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> bookList = new Dictionary<string, Book>();

            bookList.Add("01", new Book { ISBN = "01", Name = "Don't Make Me Think (Beta)", Author = "Steve Krug" });
            bookList.Add("02", new Book { ISBN = "02", Name = "User Story Mapping", Author = "Jeff Patton" });
            bookList.Add("03", new Book { ISBN = "03", Name = "The Design of Everyday Things", Author = "Don Norman" });

            Console.WriteLine("Add books to Dictionary");
            PrintValue(bookList);
            bookList["04"] = new Book { ISBN = "04", Name = "Don't Make Me Think", Author = "Steve Krug" };

            Console.WriteLine("Edit book with ISBN");
            PrintValue(bookList);
            Console.WriteLine("Search for a specific book with ISBN");
            if (bookList.ContainsKey("04") == false)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Book book = bookList["04"];
                Console.WriteLine("Found this book: " + book.Name);
            }

            bookList.Remove("04");
            Console.WriteLine("Remove book with ISBN");
            PrintValue(bookList);
        }

        public static void PrintValue(Dictionary<string, Book> books)
        {
            foreach (KeyValuePair<string, Book> kvp in books)
            {
                Book book = kvp.Value;

                Console.WriteLine("ISBN: " + book.ISBN + " - " +
                    book.Name + " - " + book.Author);
            }
            Console.WriteLine();
        }
    }
}
