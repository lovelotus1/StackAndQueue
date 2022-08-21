using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class LinkedListStack
    {
        internal Node top;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pusheed into the stack", node.data);
        }

        internal void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.WriteLine("\n" + temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("The stack is empty");
            }
            Console.WriteLine("\n{0} is in the top of the stack", this.top.data);
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Deletion is not possible");
            }
            Console.WriteLine("Deleted Node From The Stack: " + this.top.data);
            this.top = this.top.next;
        }

        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
