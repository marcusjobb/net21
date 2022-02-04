// -----------------------------------------------------------------------------------------------
//  Song.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace UnitTesting_Repetition_Live.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Song definition
/// </summary>
public class Song
{
    /// <summary>Gets or sets the artist.</summary>
    /// <value>The artist.</value>
    public string Artist { get; set; } = "";
    /// <summary>Gets or sets the title.</summary>
    /// <value>The title.</value>
    public string Title { get; set; } = "";
    /// <summary>Gets or sets the tags.</summary>
    /// <value>The tags.</value>
    public List<string> Tags { get; set; } = new();
}
