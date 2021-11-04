namespace Chat_upV2
{
    class People
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Github { get; set; }
        public string FavFood { get; set; }
        public string HateFood { get; set; }
        public string FavAnimal { get; set; }
        public string FavMovieGenre { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsGhosted { get; set; }
        public People()
        {

        }

        public People(string name, string surName, string nickname, string email, string linkedIn, string facebook, string instagram, string twitter, string github, string favFood, string hateFood, string favAnimal, string favMovieGenre, bool isBlocked, bool isGhosted)
        {
            Name = name; SurName = surName; Nickname = nickname; Email = email; LinkedIn = linkedIn; Facebook = facebook; Instagram = instagram; Twitter = twitter; Github = github; FavFood = favFood; HateFood = hateFood; FavAnimal = favAnimal; FavMovieGenre = favMovieGenre; IsBlocked = isBlocked; IsGhosted = isGhosted;

        }



    }




}
