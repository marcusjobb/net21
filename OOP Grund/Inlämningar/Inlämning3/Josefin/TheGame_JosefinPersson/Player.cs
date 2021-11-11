using System;

namespace TheGame_JosefinPersson
{
    class Player                                                                                                                                                                       
    {                                                                                                                                                                             
        public string Name { get; set; } = "";                                                                                                                                        
        public int Level { get; set; } = 1;
        public int Exp { get; set; } = 0; 
        public int Hp { get; set; } = 100; 
        public int Strength { get; set; } = 6; 
        public int Defense { get; set; } = 5; 
        public int Gold { get; set; } = 0;                       
        public string AttackPhrase { get; set; } = "ATTAAAAACK!!!";                                            
        public string DeathPhrase { get; set; } = "Oh no, my guts are spilling out...! Uuuuggggh...";                                                        

        public void ShowStats() 
        {
            Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
            Console.WriteLine("Name:     " + Name);
            Console.WriteLine("Level:    " + Level);
            Console.WriteLine("EXP:      " + Exp + "/100");
            Console.WriteLine("HP:       " + Hp);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Defense:  " + Defense);
            Console.WriteLine("Gold:     " + Gold);
            Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
        }
    }
}
