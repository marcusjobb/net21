namespace ClassReplacement
{
    using System;
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