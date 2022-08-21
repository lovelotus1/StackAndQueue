using System;
using StackAndQueue;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack And Queues Program\n");
            //LinkedListStack stack = new LinkedListStack();
            //stack.Add(70);
            //stack.Add(30);
            //stack.Add(56);
            //Console.WriteLine("\nPushed 56 on top of the stack");
            //stack.Display();
            //Console.WriteLine("\nPeek and Pop Still Stack Is Empty Operation Is Done");
            //stack.IsEmpty();
            LinkedListQueue queue = new LinkedListQueue();
            queue.EnQueue(56);
            queue.EnQueue(30);
            queue.EnQueue(70);
            Console.WriteLine("\n56 is added to the top and followed by 30 and 70");
            queue.Display();
            Console.ReadLine();
        }
    }
}