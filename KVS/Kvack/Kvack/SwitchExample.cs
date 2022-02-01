// -----------------------------------------------------------------------------------------------
//  SwitchExample.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace Kvack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal enum Months
{
    Januari=1, Februari, Mars, April, Maj, Juni, Juli, Augusti, September, Oktober, November, December
}
internal class SwitchExample
{
    public SwitchExample ()
    {
        var month = GetMonth(Months.Januari);
        var anotherMonth = GetMonth(3);
    }

    public static string GetMonth (Months month) => month.ToString();

    public static string GetMonth (int month) => month switch
    {
        1 => "Januari",
        2 => "Februari",
        3 => "Mars",
        _ => "Error",
    };
}
