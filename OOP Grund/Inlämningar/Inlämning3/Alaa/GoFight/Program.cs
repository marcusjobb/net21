using System;
using GoFight._action;

namespace GoFight
{
    class Program
    {
        static void Main(string[] args)
        {
            action goToStar = new();
            while (true)
            {
                goToStar.goToPlay();
            }
        }
    }
}
