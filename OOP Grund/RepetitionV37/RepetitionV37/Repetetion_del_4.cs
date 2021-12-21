// -----------------------------------------------------------------------------------------------
//  Repetetion_del_4.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Net21RepetitionV37
{
    public enum Animals
    {
        Cat,
        Weasel,
        Dog,
        Ferret,
        Rat
    }
    public class Repetetion_del_4
    {

        public void ShowAnimal(int animal)
        {
            Animals anim = Animals.Weasel;
            System.Console.WriteLine((Animals)animal);
        }

    }
}
