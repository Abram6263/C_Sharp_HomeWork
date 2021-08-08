using System;

namespace ClassLibrary1
{
    public class Book
    {
        private string nameBook;
        private string libraryWithBook;
        private int valuePages;
        public string NameBook
        {
            get { return nameBook; }
            set { nameBook = value; }
        }
        public string LibraryWithBook
        {
            get { return libraryWithBook; }
            set { libraryWithBook = value; }
        }

        public int ValuePages
        {
            get { return valuePages; }
            set { valuePages = value; }
        }

        public Book(string name, string library, int valuePages)
        {
            nameBook = name;
            libraryWithBook = library;
            this.valuePages = valuePages;
        }

        public Book()
        {
            nameBook = "Имя не задано";
            libraryWithBook = "Библиотека не задана";
            valuePages = 0;
        }
    }
}
