using System;

namespace Polymorfism
{
    public class ChildPerson : ParentPerson
    {
        public string Alias { get; set; }
        public ChildPerson()
        {
            Console.WriteLine("Child was initialized");
        }
    }

}
