using System;
using System.Collections.Generic;
using System.Text;

namespace ShelvingSystem
{
    class Shelf
    {
        int[,] shelfStorage = new int[3, 2];
        private int height, lenght;
        public Shelf (int height, int lenght)
        {
            this.height = height;
            this.lenght = lenght;
        }

        public void show()
        {
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    Console.WriteLine($"{shelfStorage[i, j]}");
                }
            }
        }
        
    }
}
