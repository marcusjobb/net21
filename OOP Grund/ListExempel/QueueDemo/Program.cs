﻿
namespace QueueDemo
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Skicka mail");
            q.Enqueue("Printa ut resultatet");
            q.Enqueue("Kolla på en Batman film");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Count:     "+q.Count);
            Console.WriteLine("Peek:     " + q.Peek());
            Console.WriteLine("Dequeue : " + q.Dequeue());
            Console.WriteLine("Peek:     " + q.Peek());
            Console.WriteLine("Dequeue : " + q.Dequeue());
            Console.WriteLine(q.Count);
        }
    }
}
