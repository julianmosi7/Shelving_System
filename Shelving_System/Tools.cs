using System;
using System.Collections.Generic;
using System.Text;

namespace ShelvingSystem
{
    class Tools : Product 
    {
        public Tools(int id) : base(id) { }

        public double Weight { get; set; }

        public override string Description => throw new NotImplementedException();

        public override string ShortSign => throw new NotImplementedException();
    }
}
