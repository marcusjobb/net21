namespace FamilyTreeWF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.DbInitializer.Initialize(new Database.DbAccess());

            ApplicationConfiguration.Initialize();

            Application.Run(new Forms.MainWindow());
        }
    }
}