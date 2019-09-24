using System;

namespace ShelvingSystem
{
    class Program
    {
        Shelf shelf;
        static void Main(string[] args)
        {
            Shelf shelf = new Shelf(6, 5); 
            
            Book book = new Book(1, 20, 50, 100);
            Tools tool = new Tools (2){ Weight = 3 };

            shelf.Store(2, 3, book);
            shelf.Store(4, 1, tool);
            shelf.Show();
            Console.WriteLine("\n");
            Console.WriteLine($"The workload is: {shelf.Workload()}%");
            Console.WriteLine("--------------------------------------");

            Program program = new Program();
            program.Test();            
            
        }

        public void Test()
        {
            shelf = new Shelf(6, 5);
            ReadCsv();            
        }

        public void ReadCsv()
        {
            string path = "D:/Schule/4.Klasse/POS/Shelving_System/Shelving_System/waren.csv";            
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] items = line.Split(";");
                Store(items);
            }
            shelf.Show();
            Console.WriteLine("\n");
            Console.WriteLine($"The workload is: {shelf.Workload()}%");
            Console.WriteLine("--------------------------------------");
        }

        public void Store(string[] items)
        {            
            if (items[0].Equals("Werkzeug"))
            {                              
                Tools tool = new Tools(Int32.Parse(items[3])) { Weight = Double.Parse(items[4])};
                shelf.Store(Int32.Parse(items[1]), Int32.Parse(items[2]), tool);
            }else if (items[0].Equals("Buch"))
            {
                Book book = new Book(Int32.Parse(items[3]), Int32.Parse(items[5]), Int32.Parse(items[6]), Int32.Parse(items[4]));
                shelf.Store(Int32.Parse(items[1]), Int32.Parse(items[2]), book);
            }
        }
    }
}
