// -----------------------------------------------------------------------------------------------
//  Music.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace UnitTesting_Repetition_Live;

using System.Collections.Generic;
using System.Linq;
using UnitTesting_Repetition_Live.Models;

internal class Music
{
    // Constructor
    public Music ()
    {
        // Lägger in lite låtar i listan
        Songs = new();
            Songs.AddRange(
            new Song[]
            {
                new Song{Artist="Anna-Lena Löfgren", Title="Lyckliga gatan", Tags=new(){"Schlager"} },
                new Song{Artist="Ava Max", Title="So am I", Tags=new(){"Pop","Dance-pop", "Electropop" } },
                new Song{Artist="Ava Max", Title="Sweet but Psycho", Tags=new(){"Pop","Dance-pop", "Electropop" } },
                new Song{Artist="Becky G", Title="Sin Pijama", Tags=new(){"Pop","Rock", "Latino" } },
                new Song{Artist="Bruno Mars", Title="24K Magic", Tags=new(){"Pop","Funk","Disco","R&B" } },
                new Song{Artist="Celine Dion", Title="My heart will go on", Tags=new(){"Romantic","loving" } },
                new Song{Artist="Daddy Yankee", Title="Gasolina", Tags=new(){"Reaggeton","Rock", "Latino" } },   
                new Song{Artist="Elvis", Title ="Can't help falling in love", Tags=new(){"Romantic","Blues" } },
                new Song{Artist="Evanescence", Title="Fallen", Tags=new(){"Romantic","Gothic Metal" } },
                new Song{Artist="Factory", Title="Efter Plugget", Tags=new(){"Rock","80s" } },
                new Song{Artist="Freestyle", Title="Vill Ha Dig I Mörkret Hos Mig", Tags=new(){"Pop","80s" } },
                new Song{Artist="Imperiet", Title="Du ska va president", Tags=new(){"Rock","80s" } },
                new Song{Artist="Jaques Brel", Title="Le Moribond", Tags=new(){"Vispop","Chanson"} },
                new Song{Artist="Jonathan Coulton", Title="Code monkey", Tags=new(){"Romantic","Funny"}},
                new Song{Artist="Leave the door open", Title="Silk Sonic", Tags=new(){"Soul","Funk" } },
                new Song{Artist="Nationalteatern", Title="Barn av vår tid", Tags=new(){"Rock","80s" } },
                new Song{Artist="Paul & Storm", Title="Cruel, cruel moon", Tags=new(){"Romantic","Funny","Weird" } },
                new Song{Artist="Per Gessle", Title="Regn, Regn, Regn", Tags=new(){"Pop","Nostalgic" } },
                new Song{Artist="Povel Ramel", Title="Far, jag kan inte få upp min kokosnöt", Tags=new(){"Funny","Weird"} },
                new Song{Artist="Rage against the machine", Title="Evil Empire", Tags=new(){"Angry","Hard rock" } },
                new Song{Artist="Ted Gärdestad", Title="Sol, vind och vatten", Tags=new(){"Schlager", "Svensk pop","Vispop"} },
                new Song{Artist="Terry Jacks", Title="Seasons in the Sun", Tags=new(){"Vispop","Chanson"}},
                new Song{Artist="The Beatles", Title="Hey Jude", Tags=new(){"Funny","Pop" } },
                new Song{Artist="The Beatles", Title="Yesterday", Tags=new(){"Nostalgic","Pop" } },
                new Song{Artist="The Black Eyed Peas", Title="I'm with you", Tags=new(){"Pop","Hiphop", "R&B" } },
                new Song{Artist="The Prodigy", Title="Microphone", Tags=new(){"Electronic","Techno","Bigbeat","Breakbeat","Drum'n'bass","Rock"}},
                new Song{Artist="The Rolling Stones", Title="Paint it black", Tags=new(){"Raga rock","Psychedelic rock" } },
                new Song{Artist="The Rollings Stones", Title="Miss Amanda Jones", Tags=new(){"Pop","Rock" } },
                new Song{Artist="Tommy Körberg", Title="Stad i ljus", Tags=new(){"schlager" } },
            }
        );
    }

    // Lista med sånger
    public List<Song> Songs { get; set; }

    // Söker matchande taggar mellan två låtar
    // returnerar antal träffar
    public double FindDistance (Song song1, Song song2)
    {
        var distance = 0;
        var tags1 = song1.Tags;
        var tags2 = song2.Tags;
        foreach (var tag1 in tags1)
        {
            foreach (var tag2 in tags2)
            {
                if (tag1 == tag2)
                {
                    distance++;
                }
            }
        }
        // Dividerar antal träffar med antal taggar totalt minus antal träffar
        // för att inte räkna med dubletter
        // ex: Soul, Dance Vs Soul, techno = 1 träff
        //     och fyra taggar, varav bara 3 är unika. 
        //return distance/(tags1.Count+tags2.Count-distance);
        return distance;
    }

    public Song? FindSong (string title)
    {
        return Songs.FirstOrDefault(t => t.Title.Contains(title));
    }
    public List<Song> FindArtist(string artist)
    {
        return Songs.Where(t => t.Artist.Contains(artist)).ToList();
    }

    public List<MatchingSong> FindMatchingSongs (Song song)
    {
        var match = new List<MatchingSong>();
        foreach (var comp in Songs)
        {
            if (comp != song)
            {
                // Jämför låtarna
                var dist = FindDistance(comp, song);
                // Spara matchning
                if (dist>0)
                    match.Add(new MatchingSong(song, comp, dist, song.Tags.Intersect(comp.Tags)));
            }
        }
        // Sortera listan med högsta värdet först
        return match.OrderByDescending(s => s.Score).ToList();
    }
}