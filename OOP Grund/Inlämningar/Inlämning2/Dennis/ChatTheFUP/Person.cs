namespace ChatTheFUp
{
    partial class Program
    {
        class Person
        {
            public string firstName { get; protected set; }
            public string lastName { get; protected set; }
            public int age { get; protected set; }
            public string eMail { get; protected set; }
            public string userName { get; protected set; }
            public string favFood { get; protected set; }
            public string favAnimal { get; protected set; }


            public Person(string firstName, string lastName, int age, string eMail, string userName, string favFood, string favAnimal)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.eMail = eMail;
                this.userName = userName;
                this.favFood = favFood;
                this.favAnimal = favAnimal;
            }

            public string returnDetails()
            {
                // Utskrift av person.
                return "|"+firstName + " " + lastName+ "|\n   |Age: "+ age + "\n   |E-Mail: " + eMail + "\n   |Username: " + userName + "\n   |Favorite Food: " + favFood + "\n   |Favorite Animal: " + favAnimal + "\n";
            }
            public void setFirstName(string firstName)
            {
                this.firstName = firstName;
            }

            public void setLastName(string lastName)
            {
                this.lastName = lastName;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

            public void setEmail(string eMail)
            {
                this.eMail = eMail;
            }

            public void setUserName(string userName)
            {
                this.userName = userName;
            }

            public void setFavFood(string favFood)
            {
                this.favFood = favFood;
            }

            public void setFavAnimal(string favAnimal)
            {
                this.favAnimal = favAnimal;
            }

        }
    }
}