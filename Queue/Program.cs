using System;
using System.Collections.Generic;
using MyQueue;

class Program
{
    static void Main()
    {
        CustomQueue<string> queue = new CustomQueue<string>();

        queue.Enqueue("Apple");
        queue.Enqueue("Banana");
        queue.Enqueue("Orange");

        Console.WriteLine("Elements in the queue:");
        while (!queue.IsEmpty())
        {
            string element = queue.Dequeue();
            Console.WriteLine(element);
        }

        queue.Dequeue();
    }
}
