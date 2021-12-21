using FamilyTree.Utils;
using FamilyTree.Database;
using System;

namespace FamilyTree
{
    public static class Program
    {
        private static void Main() //ENDAST instansiera och starta familjeträdet
        {
            Seeder.SeedNames();
            Menu.StartMenu();
        }
    }
}
