using System;

namespace ShelvingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Shelf shelf = new Shelf(6, 5);
            Tools tool = new Tools(1); /* weight geht unter, wohin? */
            Book book = new Book(1, 20, 50, 100);
            shelf.Store(2, 3, book);
            shelf.Show();
        }
    }
}
