using System;
using System.Collections.Generic;
using System.Text;

namespace ShelvingSystem
{
    class Shelf
    {
        private int height, lenght;
        public Shelf (int height, int lenght)
        {
            this.height = height;
            this.lenght = lenght;
        }

        public void show()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("|    |    |    |    |    |");
        }
        
    }
}
