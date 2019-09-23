using System;
using System.Collections.Generic;
using System.Text;

namespace ShelvingSystem
{
    abstract class Product
    {
        private int id;

        public Product(int id)
        {
            this.id = id++;
        }

        public abstract string Description { get; }       
         
        public abstract string ShortSign { get; }
    }
}
