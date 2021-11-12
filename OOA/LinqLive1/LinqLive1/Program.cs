namespace LinqLive1
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            var crud = new PeopleCrud();
            crud.List();

            Environment.Exit(0);

            var arr = new string[] { "One", "Two", "Three" };

            //var find = arr.Where(x => x.Contains("e")).ToList();


            arr.Where(x => x.Contains("e"))
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            var find = (
                        from x in arr
                        where x.Contains("e")
                        select x
                        ).ToList();

         }
    }
}
