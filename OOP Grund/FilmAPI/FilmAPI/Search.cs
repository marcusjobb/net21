// -----------------------------------------------------------------------------------------------
//  Search.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

#pragma warning disable IDE1006 // Naming Styles

namespace FilmAPI
{
    public class Search
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
    }
}

#pragma warning restore IDE1006 // Naming Styles