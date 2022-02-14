// -----------------------------------------------------------------------------------------------
//  Class1.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace MoqDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPeopleHandler
{
    bool VerifyEmail (IPerson person);
    bool VerifyEmail (string email);

}
