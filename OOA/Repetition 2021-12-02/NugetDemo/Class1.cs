namespace NugetDemo
{
    using System;

    public class Talker
    {
        public string SayHello()
        {
            return "Hello";
        }

        internal string SayGoodbye()
        {
            return "Goodbye";
        }

        private string SayHelloAndGoodbye()
        {
            return SayHello() + " " + SayGoodbye();
        }
    }

    public class TalkerTester
    {
        public TalkerTester()
        {
            var talk=new Talker();
            var msg = talk.SayGoodbye();
            Console.WriteLine(msg);
        }
    }
}
