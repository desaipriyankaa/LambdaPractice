using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaPractice
{
    public class ProcessData
    {
        public void Process(int x, int y, AddNumbers del)
        {
            System.Threading.Thread.Sleep(1000);
            var result = del(x, y);
            Console.WriteLine(result);
        }
        public void ProcessAction(int x, int y, Action<int, int> action)
        {
            System.Threading.Thread.Sleep(1000);
            action(x, y);
            Console.WriteLine("Action has been processed...");
        }

        public void ProcessFunc(int x, int y, Func<int, int, int> func)
        {
            System.Threading.Thread.Sleep(1000);
            var result = func(x, y);
            Console.WriteLine(result);
            Console.WriteLine("Function has been processed...");
        }
    }
}
