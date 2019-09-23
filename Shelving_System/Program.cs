using System;

namespace ShelvingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Shelf shelf = new Shelf(6, 5); 
            
            Book book = new Book(1, 20, 50, 100);
            Tools tool = new Tools (1){ Weight = 3 };

            shelf.Store(2, 3, book);
            shelf.Store(4, 1, tool);
            shelf.Show();
        }
    }
}
