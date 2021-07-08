using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Counter
    {
        public int LoopCounter { get; set; }

        public override string ToString()
        {
            return LoopCounter.ToString();
        }
    }
}
