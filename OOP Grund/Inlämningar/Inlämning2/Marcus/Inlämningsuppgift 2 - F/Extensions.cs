using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2___F
{
    static class Extensions
    {
        public static string ToString(this int month)
        {
            Enum.TryParse(typeof(Months), month.ToString(), out object str);
            return str.ToString();
        }

        public static int CalculateAge(this User user)
        {
                var age = DateTime.Today.Year - user.Birthday.Year;

                if (user.Birthday.Date > DateTime.Today.AddYears(-age)) age--;

                return age;
        }
    }
}
