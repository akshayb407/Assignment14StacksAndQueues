using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks Method");

            LinkedListStack Stack = new LinkedListStack();
            Stack.Push(70);
            Stack.Push(30);
            Stack.Push(56);
            Stack.Display();
            Stack.Pop();
            Stack.Peek();
            Stack.IsEmpty();
        }
    }
}
