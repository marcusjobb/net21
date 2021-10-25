// -----------------------------------------------------------------------------------------------
//  Pet.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace ClassRepetition_20211025
{
    using System;

    class Pet
    {

        public string Name { get => name;
            set {
                if (value.Trim().Length > 0)
                    name = value.Trim(); 
            }
        }
        private DateTime birthDate;
        private string name;

        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (value.Year >= 1990) birthDate = value;
            }
        }

        public Pet()
        {
            birthDate = new DateTime(1999, 01, 01);
        }

        public override string ToString() => Name + " " + BirthDate.ToString("yyyy MM dd");
    }
}
