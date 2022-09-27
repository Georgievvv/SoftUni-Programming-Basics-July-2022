using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string checkedBooks = Console.ReadLine();
            int counter = 0;

            while (checkedBooks != favoriteBook)
            {
                if (checkedBooks == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");

                    break;
                }

                counter++;
                checkedBooks = Console.ReadLine();
            }

            if (checkedBooks == favoriteBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
        }
    }
}
