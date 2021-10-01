// ----------------------------------------------------------------------------------------------
// This file "ListThingy.cs" is published under the GPLV3 license.
// Created 01/10/2021 10:45:22 by DESKTOP-QU5QA1S\marcu
// ----------------------------------------------------------------------------------------------

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
        public override string ToString()
        {
            return Title;
        }

        #endregion Public Methods
    }
}