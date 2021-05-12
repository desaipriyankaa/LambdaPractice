using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaPractice
{
    public class ProcessData
    {
        public void ProcessA(int x, int y, AddNumbers del)
        {
            var result = del(x, y);
            Console.WriteLine(result);
        }
        public void ProcessM(int x, int y, MultiplyNumbers del)
        {
            var result = del(x, y);
            Console.WriteLine(result);
        }
    }
}
