using System;

namespace Open_Lab_10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.SetTitle("The Two Towers");
            LOTR.SetPages(415);
            LOTR.SetCategory("Fantasy book");
            LOTR.SetAuthor("J.R.R. Tolkien");
            LOTR.SetReleaseDate("18.9.2012");
            LOTR.PrintBookInfo();
            Console.ReadKey();
        }
    }
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private string releaseDate;

        public void SetTitle(string ttl)
        {
            title = ttl;
        }
        public void SetPages(int pgs)
        {
            pages = pgs;
        }
        public void SetCategory(string ctgr)
        {
            category = ctgr;
        }
        public void SetAuthor(string athr)
        {
            author = athr;
        }
        public void SetReleaseDate(string dt)
        {
            releaseDate = dt;
        }
        public void PrintBookInfo()
        {
            Console.WriteLine("Title of the book: " + title );
            Console.WriteLine("Author of the book: " + author);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Release date: " + releaseDate); 
        }
    }
}
