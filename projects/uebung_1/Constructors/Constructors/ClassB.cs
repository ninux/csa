using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class ClassB : ClassA
    {
        public ClassB(string msg, int count) : base(msg)
        {
            // Console.Write("B:" + msg);
            for (int i = 0; i < count; i++)
            {
                Console.Write(".");
            }
            Console.Write(" ");
        }

        public ClassB(string msg) : this(msg, 0) { }

        public ClassB() : this("", 0) { }
    }
}
