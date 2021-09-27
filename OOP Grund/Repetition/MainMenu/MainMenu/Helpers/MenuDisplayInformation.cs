// Source: https://github.com/tthorin/NET21OOP/tree/main/MainMenu
namespace MainMenu.Helpers
{
    using System;
    using System.Collections.Generic;


    class MenuDisplayInformation
    {
        public int MenuHeight { get; set; } = 0;
        public int MenuWidth { get; set; } = 0;
        public int HightLightRow { get; set; } = 0;
        public int StartX { get; set; } = 0;
        public int StartY { get; set; } = 0;
        public string topLine { get; set; } = "";
        public string midLine { get; set; } = "";
        public string bottomLine { get; set; } = "";
        public string HelpText { get; set; } = " Arrowkeys to navigate, Enter to select.";
        public int CurrentY { get; set; }
    }
}