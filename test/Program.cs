using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using testing_proj;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Clac op = new Clac(20);
            Console.WriteLine(op.calculate());
        }
    }
}
