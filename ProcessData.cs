using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaPractice
{
    public class ProcessData
    {
        public void Process(int x, int y, AddNumbers del)
        {
            var result = del(x, y);
            Console.WriteLine(result);
        }
    }
}
