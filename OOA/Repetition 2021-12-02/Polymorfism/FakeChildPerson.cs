using System;

namespace Polymorfism
{
    public class FakeChildPerson
    {
        private ParentPerson parent=new ParentPerson();

        public string Name { get { return parent.Name; } set { parent.Name = value; } }
        public int Age { get { return parent.Age; } set { parent.Age = value; } }
        public string Alias { get; set; }

        public FakeChildPerson()
        {
            Console.WriteLine("Fake Child was initialized");
        }
    }

}
