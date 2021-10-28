namespace Livekodning_Arv_01
{
    using System;
    using System.Collections.Generic;

    using Plugin1;
    using Plugin2;
    internal class Program
    {
        static void Main(string[] args)
        {
            //var poem = new WritePoem(new FilePrinter());
            //poem.Poem();

            List<Plugin> plugins = new();
            plugins.Add(new PoemWriter());
            plugins.Add(new Joke());

            foreach (Plugin plugin in plugins)
            {
                plugin.Start();
                Console.WriteLine();
            }
            
            Console.WriteLine();
            
            foreach (Plugin plugin in plugins)
            {
                plugin.Stop();
            }

        }
    }
}
