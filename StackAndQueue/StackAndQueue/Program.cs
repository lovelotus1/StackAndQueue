using System;
using StackAndQueue;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack And Queues Program\n");
            LinkedListStack stack = new LinkedListStack();
            stack.Add(70);
            stack.Add(30);
            stack.Add(56);
            Console.WriteLine("\nPushed 56 on top of the stack");
            stack.Display();
            Console.ReadLine();
        }
    }
}