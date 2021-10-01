// -----------------------------------------------------------------------------------------------
//  ListThingy.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FilmAPI
{
    /// <summary>
    /// Defines the <see cref="ListThingy" />.
    /// </summary>
    public class ListThingy
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the IMDB.
        /// </summary>
        public string IMDB { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// The ToString.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public override string ToString() => Title;

        #endregion Public Methods
    }
}