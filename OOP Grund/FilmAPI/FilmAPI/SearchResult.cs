// -----------------------------------------------------------------------------------------------
//  SearchResult.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

#pragma warning disable IDE1006 // Naming Styles
namespace FilmAPI
{
    public class SearchResult
    {
        public Search[] Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
    }
}
#pragma warning restore IDE1006 // Naming Styles
