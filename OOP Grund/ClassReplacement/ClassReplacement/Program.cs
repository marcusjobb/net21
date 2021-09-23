using System;

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
