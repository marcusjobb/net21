using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_Repetition_Live.Models;

namespace UnitTesting_Repetition_Live.Models.Tests
{
    [TestClass()]
    public class MatchingSongTests
    {
        [TestMethod()]
        public void MatchingSongTest ()
        {
            var song1 = new Song { Artist = "a", Title = "a", Tags = new() { "a" } };
            var song2 = new Song { Artist = "b", Title = "b", Tags = new() { "b" } };
            int score = 12;
            var tags = new[] { "a", "b" };
            
            var ms = new MatchingSong(song1, song2, score, tags);

            Assert.AreEqual(score, ms.Score);
            Assert.AreEqual(song1, ms.Song1);
            Assert.AreEqual(song2, ms.Song2);
            //Assert.AreEqual(string.Join(',',tags.ToList()), string.Join(',', ms.MatchingTags));
            CollectionAssert.AreEqual(tags.ToList(), ms.MatchingTags);
        }
    }
}
// -----------------------------------------------------------------------------------------------
//  MatchingSongTests.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------
