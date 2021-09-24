namespace MainMenu
{
    using System;
    using System.Collections.Generic;

    public class TeacherMenu : Menu
    {
        // Visar menyn
        public override void ShowMenu()
        {
            Console.Clear();

            // Hitta hur brett menyn är allt som allt
            int maxWidth = Title.Length;
            foreach (var row in MenuOptions)
            {
                if (row.Length > maxWidth) maxWidth = row.Length;
            }
            maxWidth += 5; // to be able to handle numbers too

            string top = "╔" + new string('═', maxWidth) + "╗";
            string middle = "╠" + new string('═', maxWidth) + "╣";
            string bottom = "╚" + new string('═', maxWidth) + "╝";

            Console.WriteLine(top);
            Console.WriteLine(Title);
            Console.WriteLine(middle);
            for (int i = 0; i < MenuOptions.Count; i++)
            {
                // Lägger till 1 i menyvalen för att användaren inte ska behöva tänka på att
                // börja från 0
                Console.WriteLine("[" + (i + 1) + "] " + MenuOptions[i]);
            }
            Console.WriteLine(bottom);
        }
    }
}
