using System;
using System.Collections.Generic;
using System.Text;

namespace ShelvingSystem
{
    class Book : Product
    {
        private int id, width, height, lenght;

        public Book(int id, int width, int height, int lenght) : base(id)
        {
            this.width = width;
            this.height = height;
            this.lenght = lenght;
        }

        public override string Description
        {
            get
            {
                return $"#{id}: Buch {width} {height} {lenght}";
            }
        }
            

        public override string ShortSign
        {
            get
            {
                return "B";
            }
        }
    }
}
