using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2___F
{
    class User
    {
        public string FirstName { get; set; } = "<Name>";
        public string LastName { get; set; } = "<Last name>";
        public string Alias { get; set; } = "<Alias>";
        public string Email { get; set; } = "<E-mail>";
        public string LinkedIn { get; set; } = "<Linked In>";
        public string Facebook { get; set; } = "<Facebook>";
        public string Instagram { get; set; } = "<Instagram>";
        public string Twitter { get; set; } = "<Twitter>";
        public string Github { get; set; } = "<Github>";
        public string FavoriteFood { get; set; } = "<Favorite Food>";
        public string DislikedFood { get; set; } = "<Disliked Food>";
        public string FavoriteAnimal { get; set; } = "<Favorite Animal>";
        public string FavoriteMovieGenre { get; set; } = "<Favorite Movie Genre>";
        public bool IsBlocked { get; set; } = false;
        public bool IsGhosted { get; set; } = false;
        public DateTime Birthday { get; set; } = DateTime.Today;
    }
}