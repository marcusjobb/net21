﻿// -----------------------------------------------------------------------------------------------
//  Interface2.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Livekodning_Arv_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface Plugin
    {
        public void Start();
        public void Stop();
        public void Settings();
    }
}
