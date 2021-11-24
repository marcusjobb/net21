namespace EF_Demo1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.EntityFrameworkCore;

    internal class Program
    {
        static void Main()
        {
            using (var db = new Database.TestDB())
            {
                //var scores = db.HiScores.Include("Player").Where(score => score.Score == 110).ToList();

                //foreach (var item in scores)
                //{
                //    Console.WriteLine(item?.Player.Name ?? "(unknown)" + "\t" + item.Score);
                //}

                var marc = db.Players.FirstOrDefault(x => x.Id == 1);
                var newPlayer = new Models.Player
                {
                    Name = "Someone",
                    Friends = new List<Models.Player>
                    {
                        new Models.Player{Name="Friend 1"},
                        new Models.Player{Name="Friend 2"},
                        new Models.Player{Name="Friend 3"},
                        new Models.Player{Name="Friend 4"},
                    },
                };
                db.Players.Add(newPlayer);

                //var hisc = new Models.HiScore { 
                //    Score = 43, 
                //    Player = marc};
                //db.HiScores.Add(hisc);
                db.SaveChanges();
            }
        }
    }
}
