// -----------------------------------------------------------------------------------------------
//  Printout.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Livekodning_Arv_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class WritePoem
    {
        internal IPrinter OutputHandler { get; set; }
        public WritePoem(IPrinter outputHandler)
        {
            this.OutputHandler = outputHandler;
        }

        internal void Poem()
        {
            OutputHandler.PrintThis(@"Förruttnelse, hasta, o älskade brud,
    att bädda vårt ensliga läger!
Förskjuten av världen, förskjuten av Gud,
    blott dig till förhoppning jag äger.
Fort, smycka vår kammar -- på svartklädda båren
den suckande älskarn din boning skall nå.
Fort, tillred vår brudsäng -- med nejlikor våren
    skall henne beså.");
        }
    }

    internal interface IPrinter
    {
        void PrintThis(string text);
    }

    internal class Printout : IPrinter
    {
        public virtual void PrintThis(string text)
        {
            Console.WriteLine(text);
        }
    }

    internal class FilePrinter : Printout
    {
        public override void PrintThis(string text)
        {
            base.PrintThis(text);
            System.IO.File.AppendAllText("output.txt", text);
        }
    }

    internal class DebugPrinter : IPrinter
    {
        public void PrintThis(string text)
        {
            System.Diagnostics.Debug.WriteLine(text);
        }
    }

}
