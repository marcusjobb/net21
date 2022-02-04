using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_Repetition_Live;
using UnitTesting_Repetition_Live.Models;

namespace UnitTesting_Repetition_Live.Tests
{
    [TestClass()]
    public class MusicTests
    {
        Music music=new Music();
        [TestInitialize]
        public void Init()
        {
            music.Songs = new();
            music.Songs.AddRange(
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
        [TestMethod()]
        public void FindDistanceTest ()
        {
            // Arrange
            var song1 = music.FindSong("Le Moribond");
            var song2 = music.FindSong("Seasons in the Sun");
            var expected = 2;
            // Act

            var dist = music.FindDistance(song1,song2);

            // Assert
            Assert.AreEqual(expected, dist);
        }

        [TestMethod()]
        [DataRow("Le Moribond", null, 0)]
        [DataRow(null,"Le Moribond", 0)]
        [DataRow(null, null, 0)]
        public void FindDistanceTest_null (string title1, string title2, int expected)
        {
            // Arrange
            var song1 = music.FindSong(title1);
            var song2 = music.FindSong(title2);
            // Act

            var dist = music.FindDistance(song1, song2);

            // Assert
            Assert.AreEqual(expected, dist);
        }

        [TestMethod()]
        [DataRow("The Beatles", 2)]
        [DataRow("Povel Ramel", 1)]
        [DataRow("Marcus Medina", 0)]
        public void FindArtistTest (string artist, int expected)
        {
            // Arrange

            // Act
            var found = music.FindArtist(artist);

            // Assert
            Assert.AreEqual(expected, found.Count);
        }

        [TestMethod()]
        [DataRow("Barn av vår tid", 7)]
        [DataRow(null, 0)]
        public void FindMatchingSongsTest (string song, int expected)
        {
            var found = music.FindSong(song);
            var match = music.FindMatchingSongs(found);

            Assert.AreEqual(expected, match.Count);
        }
    }
}
