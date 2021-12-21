// -----------------------------------------------------------------------------------------------
//  FileOutput.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace ClassReplacement
{
    using System.IO;

    internal class FileOutput : Output
    {
        private bool FirstWrite = true;
        public string FileName { get; set; } = "MyText.txt";
        public override void Print(string text)
        {
            if (FirstWrite)
            {
                File.WriteAllText(FileName, ""); // Tömmer filen först
                FirstWrite = false;
            }
            File.AppendAllText(FileName, text + "\r\n"); // Lägger till rad
        }
    }
}