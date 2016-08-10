using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 委托
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate md = new Mydelegate(M1);
            md();
            Console.WriteLine("OK");
            Console.ReadKey();
        }
        static void M1()
        {
            Console.WriteLine("11111");
        }
    }
    public delegate void Mydelegate();
}
