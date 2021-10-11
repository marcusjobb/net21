using System;
using System.Collections.Generic;
using System.Threading;

namespace Polymorfism_Livekod211011
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------------
            // Använder olika versioner av StringHelper i samma program
            //-------------------------------------------------------------------------------------------------
            var sh1 = new StringHelper();
            var sh2 = new StringHelperV2();

            //-------------------------------------------------------------------------------------------------
            // testar att köra samma metod från båda klasserna
            //-------------------------------------------------------------------------------------------------
            Console.WriteLine(sh1.ToInt("100"));
            Console.WriteLine(sh2.ToInt("100"));

            var file = new FileStuffX();

            //-------------------------------------------------------------------------------------------------
            // Skapar en lista av klasser som implemmenterar Hello
            // Metoderna i listan kan inte se Insult
            //-------------------------------------------------------------------------------------------------
            List<IHello> helloList = new List<IHello>();
            helloList.Add(new Spanish());
            helloList.Add(new English());

            foreach (var hello in helloList)
            {
                hello.SayHello();
                hello.SayGoodbye();
            }

            //-------------------------------------------------------------------------------------------------
            // Skapar en lista av klasser som implemmenterar Insult
            // Objekten i listan kan inte se metoderna Hello och Goodbye
            //-------------------------------------------------------------------------------------------------
            List<Insulter> insultList = new List<Insulter>();
            insultList.Add(new Spanish());
            insultList.Add(new English());

            foreach (var hello in insultList)
            {
                hello.Insult();
                hello.SayCat();
            }


        }
    }

    internal class English : IHello, Insulter
    {
        public void SayHello() => Console.WriteLine("Hello");
        public void SayGoodbye() => Console.WriteLine("Bye");
        public void Insult() => Console.WriteLine("Idiot");
    }

    public interface IGame
    {
        void StartGame();
        void GetHighscore();
        bool IsPlaying { get; set; }
    }

    public interface IHello
    {
        void SayHello();
        void SayGoodbye();
    }

    public interface Insulter
    {
        void Insult();
        void SayCat() => Console.WriteLine("Meow");
    }
    public class Spanish : IHello, Insulter
    {
        public void SayHello() => Console.WriteLine("Hola");
        public void SayGoodbye() => Console.WriteLine("Chao");
        public void Insult() => Console.WriteLine("Idiota");
    }

}