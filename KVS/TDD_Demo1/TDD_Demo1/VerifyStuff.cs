// -----------------------------------------------------------------------------------------------
//  VerifyStuff.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace Namespace
{
    public class VerifyStuff
    {
        public bool VerifyPhoneNumber (string phone)
        {
            var check = phone.StartsWith("+");
            foreach (var item in phone.Substring(1))
            {
                check = check && "0123456789".Contains(item);
            }

            return check;
        }
    }
}