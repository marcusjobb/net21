// -----------------------------------------------------------------------------------------------
//  Movie.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

#pragma warning disable IDE1006 // Naming Styles

namespace FilmAPI
{
    using System;

    public class Movie
    {
        public string Title { get; set; } = "";
        public string Year { get; set; } = "";
        public string Rated { get; set; } = "";
        public string Released { get; set; } = "";
        public string Runtime { get; set; } = "";
        public string Genre { get; set; } = "";
        public string Director { get; set; } = "";
        public string Writer { get; set; } = "";
        public string Actors { get; set; } = "";
        public string Plot { get; set; } = "";
        public string Language { get; set; } = "";
        public string Country { get; set; } = "";
        public string Awards { get; set; } = "";
        public string Poster { get; set; } = "";
        public Rating[] Ratings { get; set; } = Array.Empty<Rating>();
        public string Metascore { get; set; } = "";
        public string imdbRating { get; set; } = "";
        public string imdbVotes { get; set; } = "";
        public string imdbID { get; set; } = "";
        public string Type { get; set; } = "";
        public string DVD { get; set; } = "";
        public string BoxOffice { get; set; } = "";
        public string Production { get; set; } = "";
        public string Website { get; set; } = "";
        public string Response { get; set; } = "";
    }
}

#pragma warning restore IDE1006 // Naming Styles