namespace FilmAPI
{
    public class ListThingy
    {
        public string Title { get; set; }
        public string IMDB { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}