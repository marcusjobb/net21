using System;
using ChattApplication_F.sitt;
using ChattApplication_F.memb;

namespace ChattApplication_F
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                sitting.mainMenu();
                Members.invoke();
            }
        }
    }
}
