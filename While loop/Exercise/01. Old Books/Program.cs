using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();

            int books = 0;
            bool isFound = false;
            string currentBook;
            while ((currentBook = Console.ReadLine()) != "No More Books")
            {
                if (searchedBook == currentBook )
                {
                    isFound = true;
                    break;
                }
                books++;
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {books} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {books} books.");
            }
        }
    }
}
