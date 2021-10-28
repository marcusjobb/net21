// -----------------------------------------------------------------------------------------------
//  Class1.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Plugin1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Livekodning_Arv_01;

    public class PoemWriter : Plugin
    {
        public void Settings() => Console.WriteLine("Poem Settings...");
        public void Start() => Console.WriteLine(@"Once upon a midnight dreary, while I pondered, weak and weary,
Over many a quaint and curious volume of forgotten lore—
    While I nodded, nearly napping, suddenly there came a tapping,
As of some one gently rapping, rapping at my chamber door.
“’Tis some visitor,” I muttered, “tapping at my chamber door—
            Only this and nothing more.”");
        public void Stop() => Console.WriteLine("Poem stop");
    }
}
