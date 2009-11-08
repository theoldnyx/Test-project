using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testing_proj
{
    class Clac
    {
        private int number;
        public Clac(int number)
        { this.number = number; }

        public int calculate()
        {
            this.number += 10;
            return number;
        }
    }
}
