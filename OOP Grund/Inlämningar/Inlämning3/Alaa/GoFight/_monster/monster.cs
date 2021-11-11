using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFight._monster
{
    enum monsterName { Alpha, Beta, Gamma, Delta, Epsilon, Zeta, Eta, Theta, Iota, Koppa }
    class monster
    {
        //Fields and properties
        public monsterName monName { get; set; }
        public int monsterHealthPoint { get; set; }
        public int monsterMaxAttack { get; set; }
        public int monsterMaxBlock { get; set; }
        public int monsterGold { get; set; } = 0;



        Random rnd = new Random();

        public int mosterAttack()
        {
            return rnd.Next(1, monsterMaxAttack);
        }

        public int monsterBlock()
        {
            return rnd.Next(1, monsterMaxBlock);
        }
    }
}
