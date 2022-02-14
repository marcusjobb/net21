// -----------------------------------------------------------------------------------------------
//  PeopleHandler.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace MoqDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoqDemo.Interfaces;

public class PeopleHandler : IPeopleHandler
{
    public bool VerifyEmail (IPerson person)
    {
        return VerifyEmail(person.Email);
    }
    public bool VerifyEmail (string email)
    {
        return email.Contains('@');
    }
}
