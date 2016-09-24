using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Test
    {
        public Test()
        {
            Test1();
            Test2();
        }

        public void Test1()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;

            Method1(ref a, out b, out c, ref d, ref e);

            Console.Write("a={0} b={1} c={2} d={3} e={4}", a, b, c, d, e);
        }

        public void Method1(ref int a, out int b, out int c, ref int d, ref int e)
        {
            a = a + 1;
            b = 2;
            c = 2 * d;
            d = c + e;
        }

        public void Test2()
        {
            C a = new C();
            C b = new C();
            C c = new C();
            C d = new C();
            C e = new C();

            b.X = 2;
            c.X = 3;

        }

       public void Method2(out C a, out C b, C c, C d, C e)
        {
            b = new C();
            a = b;
            c = b;
            d = new C();
            d.X = 7;
            e.X= 9;
        }

        public class C
        {
            public int X;
        }

        static void Main(string[] args)
        {
            Test t = new Test();
            Console.Read();
        }
    }
}
