using System;

namespace Fdate002
{

        public class Person

        {
            private string firstName = " ";
            private string lastName = " ";
            private string alias = " ";
            private string mail = " ";    
            private string linkedIn = "https://www.linkedin.com/in/? ";
            private string faceBook = "https://www.facebook.com/? ";
            private string instaGram = "https://www.instagram.com/?";
            private string twitter = " @? ";
            private string gitHub = "https://www.github.com/? ";
            private string favouriteFood = " ";
            private string leastFavouriteFood = " ";
            private string favouriteMovieGenre = " ";
            private string favouriteAnimal = " ";

            public string FirstName         // No. 0
            {
                get { return firstName; }                     
                set { firstName = StyleUp(value); firstName = Truncate(firstName,30); }     
            }

            public string LastName  // no 1
            {
                get { return lastName; }
                set { lastName = StyleUp(value); lastName = Truncate(lastName,30); }   // när jag lade logiken direkt i set-accessorn funkade det inte, av ngn anledning.
            }

            public DateTime DateOfBirth { get; set; } // no 2//

            public bool IsBlocked { get; set; } = false;   
            public bool IsGhosted { get; set; } = false;  

            public string ID { get; set; } = " ";
            public string Mail 
            {
                get { return mail; }
                
                set
                {
                if (value != "")                                            // tom inmatning lämnar värdet oförändrat
                    {
                    mail = value; mail = Truncate(mail, 30);
                    }
                }
            } 
            public string Alias
                {
                get { return alias; }

                set
                    {
                    if (value != "")
                        {
                            alias = StyleUp(value); alias = Truncate(alias, 20);
                        }
                    }
                }


        public string LinkedIn
        {
            get
            {
                return linkedIn;
            }
            set
            {
                if (value != "")
                {
                    linkedIn = "https://www.linkedin.com/in/" + value; linkedIn = Truncate(linkedIn, 40);
                }
            }
        }
        public string FaceBook
        {
            get
            {
                return faceBook;
            }
            set
            {
                if (value != "")
                {
                    faceBook = "https://www.facebook.com/" + value; faceBook = Truncate(faceBook, 40);
                }
            }
        }


            public string InstaGram
        {
            get
            {
                return instaGram;
            }
            set
            {
                if (value != "")
                {
                    instaGram = "https://www.instagram.com/" + value; instaGram = Truncate(instaGram, 40);
                }
            }
        }

            public string Twitter
        {
            get
            {
                return twitter;
            }
            set
            {
                if (value != "")
                {
                    twitter = "@" + value; twitter = Truncate(twitter, 15);
                }
            }
        }
        public string GitHub
        {
            get
            {
                return gitHub;
            }
            set
            {
                if (value != "")
                {
                    instaGram = "https://www.github.com/" + value; gitHub = Truncate(gitHub, 40);
                }
            }
        }
        public string FavouriteFood
        {
            get
            {
                return favouriteFood;
            }
            set
            {
                if (value != "")
                {
                    favouriteFood = value; favouriteFood = Truncate(favouriteFood, 40);
                }
            }
        }
        public string LeastFavouriteFood
        {
            get
            {
                return leastFavouriteFood;
            }
            set
            {
                if (value != "")
                {
                    leastFavouriteFood = value; leastFavouriteFood = Truncate(leastFavouriteFood, 40);
                }
            }
        }
        public string FavouriteMovieGenre

        {
            get
            {
                return favouriteMovieGenre;
            }
            set
            {
                if (value != "")
                {
                    favouriteMovieGenre = value; favouriteMovieGenre = Truncate(favouriteMovieGenre, 40);
                }
            }
        }
        public string FavouriteAnimal

        {
            get
            {
                return favouriteAnimal;
            }
            set
            {
                if (value != "")
                {
                    favouriteAnimal = value; favouriteAnimal = Truncate(favouriteMovieGenre, 40);
                }
            }
        }

        private static string StyleUp(string input)
          {
            if (input.Length > 0)
            {
                input = input.Trim();
            string[] badBoys = new string[] {  "*", ".", "\t", ".", ",", ":", ";", "!", "?", "%" };
            for (int i = 0; i < badBoys.Length; i++)
            {
                input = input.Replace(badBoys[i], "");
            }

                var firstLetter = input.Substring(0, 1).ToUpper();
                var theRest = input.Substring(1).ToLower();
                return firstLetter + theRest;
            }
            else return " ";
          }

        private static string Truncate (string input, int length)
        {
            if ( input.Length > length)
            {
                input = input.Substring(0, length);
              //123456789012345678901234567890
            }

            return input;
        }


    }

    

}

