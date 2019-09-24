using System;
using System.Collections.Generic;
using System.Text;

namespace ShelvingSystem
{
    class Tools : Product 
    {
        private int id;
        public Tools(int id) : base(id) { this.id = id; }

        public double Weight { get; set; }        

        public override string Description
        {
            get
            {
                return $"#{id}: Tool {Weight} kg";
            }
        }

        public override string ShortSign
        {
            get
            {
                return "W";
            }
        }
    }
}
