// -----------------------------------------------------------------------------------------------
//  Player.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace EF_Demo1.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Player Friend { get; set; }
        public virtual ICollection<Player> Friends{ get; set; }
    }
}
