namespace PolymorfismLive
{
    internal interface IItemPurchaseable
    {
        // har så lite som möjligt

        // allt är publikt, så man skriver inte åtkomstgrad
        // inget är statiskt
        // bara deklarationer, ingen kod  (C# <7)
        // inga variabler, alltid properties
        // flera interfaces kan implemteras i samma klass
        int Add(int x, int y) { return x + y; }
    }


    // Sealed = Tillåter inte arv
    // protected = som private för alla utom de som ärver
    // virtual = det är ok att overrida
    // new = strunta i alla regler och skapa metoden ändå, ej kompatibel med polymorfism
    // klassen har allt man kan tänkas behöva till de som ärver
    // man kan bara ärva en klass
    // 
    class Store
    {
        protected int Id;

        public virtual string GetName()
        {
            string name = "Store";
            return name;
        }
    }
}