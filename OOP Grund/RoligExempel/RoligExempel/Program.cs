namespace RoligExempel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Sockets;

    class Program
    {
        static void Main(string[] args)
        {
            string message = "Leta efter något positivt varje dag, även om du behöver leta lite extra mycket vissa dagar.";
            Console.WriteLine(message);

            //string newMessage = "ha en trevlig helg";
            //List<int> code = new();
            //foreach (var item in newMessage)
            //{
            //    code.Add(message.IndexOf(item));
            //}
            //Console.WriteLine();

            //for (int i = 0; i < newMessage.Length; i++)
            //{
            //    var pos = message.IndexOf(newMessage[i]);
            //    var howMany = code.Count(x => x == pos);
            //    if (howMany>1)
            //    {
            //        code[i]= message.LastIndexOf(newMessage[i]);
            //    }
            //}

            //foreach (var item in code)
            //{
            //    Console.Write(item+", ");
            //}
            //Console.WriteLine();

            int[] acode = { 50, 3, 84, 76, 11, 84, 2, 9, 76, 23, 61, 20, 87, 4, 50, 1, 56, 13 };
            foreach (var position in acode)
            {
                Console.Write(message[position]);
            }

        }
    }
}
