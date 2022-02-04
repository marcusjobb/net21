// -----------------------------------------------------------------------------------------------
//  MatchingSongs.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace UnitTesting_Repetition_Live.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// DTO for Matching songs
/// </summary>
public class MatchingSong
{
    /// <summary>Initializes a new instance of the <see cref="MatchingSong"/> class.</summary>
    /// <param name="song1">The song1.</param>
    /// <param name="song2">The song2.</param>
    /// <param name="score">The score.</param>
    /// <param name="tags">The tags.</param>
    public MatchingSong (Song song1, Song song2, double score, IEnumerable<string> tags)
    {
        Song1 = song1;
        Song2 = song2;
        Score = score;
        MatchingTags = new(tags);
    }
    /// <summary>Gets the song1.</summary>
    /// <value>The song1.</value>
    public Song Song1 { get; }
    /// <summary>Gets the song2.</summary>
    /// <value>The song2.</value>
    public Song Song2 { get; }
    /// <summary>Gets the score.</summary>
    /// <value>The score.</value>
    public double Score { get; }
    /// <summary>Gets the matching tags.</summary>
    /// <value>The matching tags.</value>
    public List<string> MatchingTags { get; }
}
