// -----------------------------------------------------------------------------------------------
//  HiScore.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace EF_Demo1.Models
{
    using System.ComponentModel.DataAnnotations;

    public class HiScore
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
        public Player Player { get; set; }
    }
}
