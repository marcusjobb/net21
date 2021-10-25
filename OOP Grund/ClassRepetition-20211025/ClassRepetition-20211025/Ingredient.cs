using System.Text;

namespace ClassRepetition_20211025
{
    // Publik = Alla som importerar DLL filen kan använda klassen
    // Internal = Alla inom DLL filen kan använda klassen
    // Protected = privat för alla utom de som ärver

    class Ingredient
    {
        // Publik = Alla som importerar DLL filen kan använda metoder/properties
        // Internal = Alla inom DLL filen kan använda metoder/properties
        // Protected = privat för alla utom de som ärver
        // Private = privat för alla utom själva klassen

        // Vid programstart skapas en instans av detta
        // En plats i minnet
        internal static string Info = "";

        // Vid vanlig instansiering instansieras dessa på någon annan plats i minnet
        // En plats för var instans
        internal string Name = "";
        internal double Amount = 0;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Info);
            sb.AppendLine(Name);
            sb.AppendLine(Amount.ToString());
            return sb.ToString();
        }
    }
}
