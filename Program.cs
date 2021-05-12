using System;

namespace LambdaPractice
{
    public delegate int AddNumbers(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers del = (a, b) => a + b;
            AddNumbers multdel = (a, b) => a * b;
            var data = new ProcessData();
            data.Process(2, 3, del);
            data.Process(10, 3, multdel);
            Console.WriteLine("Processed");

            Action<int, int> myAction = (a, b) => Console.WriteLine(a + b);
            Action<int, int> myMultiplyAction = (a, b) => Console.WriteLine(a * b);
            data.ProcessAction(4, 5, myAction);
            data.ProcessAction(4, 5, myMultiplyAction);
        }
    }
}
