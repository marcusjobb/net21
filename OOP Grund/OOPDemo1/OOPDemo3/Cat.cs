// -----------------------------------------------------------------------------------------------
//  Cat.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace OOPDemo3
{
    // POCO = Plain Old C Object
    //        Plain Old Class Object
    // POJO = Plain Old Java Object
    internal class Cat // namn i singularis
    {
        private string name;
        private int age;
        private string colour;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value.Trim();
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) age = 0;
                else
                    age = value;
            }
        }
        public string Colour
        {
            get => colour;
            set
            {
                colour = value.Trim();
            }
        }
    }
}