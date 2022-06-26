using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Method");

           // LinkedListStack Stack = new LinkedListStack();
           // Stack.Push(70);
           // Stack.Push(30);
           // Stack.Push(56);
          //  Stack.Display();
          //  Stack.Pop();
          //  Stack.Peek();
          // Stack.IsEmpty();

            LinkedListQueue Queue = new LinkedListQueue();
            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.Display();
        }
    }
}
