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
    public class LinkedListQueue
    {
        internal Node front;
        internal void Display()
        {
            Node temp = this.front;
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine("\n" + temp.data);
                temp = temp.next;
            }
        }

        internal void EnQueue(int data)
        {
            Node node = new Node(data);
            if (this.front == null)
            {
                this.front = node;
            }
            else
            {
                Node temp = front;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is added into queue ", node.data);
        }
        internal void DeQueue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Deletion is not possible");
            }
            Console.WriteLine("Deleted node from queue: " + this.front.data);
            this.front = this.front.next;
        }
    }
}
