// See https://aka.ms/new-console-template for more information
using UnitTesting_Repetition_Live;

Console.WriteLine("Hello, unit testing!");

//var poem = new TextList(@"C:\Users\marcu\OneDrive - Software Skills International AB\Dokument\Net21\GitHub\KVS\UnitTesting_Repetition_Live\UnitTesting_Repetition_Live\Poem.txt");

//var row = poem.FindRowContaining("lenore");
//Console.WriteLine(poem.GetRow(row));

var music = new Music();
var song1 = music.FindSong("Barn av vår tid");
if (song1 != null)
{
    Console.WriteLine($"Searching for matching songs for {song1.Title}");
    foreach (var song in music.FindMatchingSongs(song1))
    {
        Console.Write (Math.Round(song.Score, 2) + " : " + song.Song2.Title + " - " + song.Song2.Artist);
        Console.WriteLine(" ("+ string.Join(", ",song.MatchingTags).Trim().TrimEnd(',')+")");
    }
}

// Jämför två strängar med Jaacard
//var j = new Jaacard("Blues, Soul", "Metal, Blues");
//Console.WriteLine(j.Distance);
//j = new Jaacard("Blues, Soul", "Blues, Soul, Negro spiritual");
//Console.WriteLine(j.Distance);
