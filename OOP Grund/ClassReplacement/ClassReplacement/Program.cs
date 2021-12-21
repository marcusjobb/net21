// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace ClassReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            Output opt = new FileOutput();

            //FileOutput opt2 = (FileOutput)opt;
            //opt2.FileName = "HelloWorld.txt";

            opt.Box(" Hello World ");
        }
    }
}
