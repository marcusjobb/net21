namespace Polymorfism
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            var fchild = new FakeChildPerson();
            var child = new ChildPerson();
            var children = new List<ParentPerson> { new ChildPerson(), new ParentPerson() };
            // ParentPerson child2 = new FakeChildPerson(); // Funkar inte
        }
    }
}
