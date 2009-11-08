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
            Console.Write("Please write a number : ");
            int userin = Console.Read();
           
            Clac op = new Clac(userin);
            Console.WriteLine("The result ",op.calculate());
        }
    }
}
