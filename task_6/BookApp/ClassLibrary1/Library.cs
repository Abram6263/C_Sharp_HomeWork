using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Library
    {
        private Book[] books;
        public Book[] GetBooks()
        {
            return books;
        }
        public Library()
        {
            books = new Book[4] { new Book("Книга 1", "Библиотека 1", 100), new Book("Книга 2", "Библиотека 2", 200),
                new Book("Книга 3", "Библиотека 3", 300), new Book("Книга 4", "Библиотека 4", 400) };
        }
        public void SearchByNumberBook(int num)
        {
            Console.WriteLine($"{books[num - 1].NameBook} {books[num - 1].LibraryWithBook} страниц {books[num - 1].ValuePages}");
        }

        public void SearchByNameBook(string name)
        {
            int y = 0;
            foreach(Book i in books)
            {
                if(i.NameBook == name)
                {
                    Console.WriteLine($"{i.NameBook} {i.LibraryWithBook} страниц {i.ValuePages}");
                    y++;
                }
            }
            if (y == 0)
            {
                Console.WriteLine("Такой книги нет!");
            }
        }

        
    }
}
