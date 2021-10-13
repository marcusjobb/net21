namespace ChatUpNameList
{
    using ChatUpNameList.App;
    public static class Program
    {
        public static void Main()
        {
            var cl = new ContactList();
            cl.Seed();
            cl.Menu();
        }
    }
}