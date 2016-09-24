using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA AA = new ClassA("AA");
            ClassA AB = new ClassB("AB");
            ClassB BB = new ClassB("BB");

            Console.Read();
        }
    }
}
