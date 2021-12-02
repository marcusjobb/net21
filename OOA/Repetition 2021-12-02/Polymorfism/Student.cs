using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorfism
{
    public class Student : PeopleHandler
    {
        public Courses Courses
        {
            get => default;
            set
            {
            }
        }

        public void Enroll()
        {
            throw new System.NotImplementedException();
        }

        public void Gratuate()
        {
            throw new System.NotImplementedException();
        }
    }
}

// -----------------------------------------------------------------------------------------------
//  Student.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

