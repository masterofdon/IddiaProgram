using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IddiaProgram
{
    class DamnA
    {
        public int x;
        public int y;
        public DamnA(int a,int b)
        {
            x = a;
            y = b;
        }
        public DamnA(DamnA a)
        {
            this.x = a.x;
            this.y = a.y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DamnA a = new DamnA(10,20);
            //DamnA b = new DamnA(20, 30);
            //b = a;

            DamnA b = new DamnA(a);
            Console.WriteLine(a.x.ToString() + " " + a.y.ToString());
            Console.WriteLine(b.x.ToString() + " " + b.y.ToString());
            a.x = 20;
            a.y = 30;
            Console.WriteLine(a.x.ToString() + " " + a.y.ToString());
            Console.WriteLine(b.x.ToString() + " " + b.y.ToString());
        }
    }
}
