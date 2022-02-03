namespace UnitTesting_Repetition_Live;
class Jaacard
{
    /// <summary>Gets or sets the first string.</summary>
    /// <value>The first.</value>
    public string First { get; set; }
    /// <summary>Gets or sets the second.</summary>
    /// <value>The second.</value>
    public string Second { get; set; }
    /// <summary>Gets the distance.</summary>
    /// <value>The distance.</value>
    public double Distance { get; }
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    public Jaacard (string first, string second)
    {
        First = first;
        Second = second;
        Distance = GetJaacardDistance(First, Second);
    }

    // https://en.wikipedia.org/wiki/Jaccard_index
    public double GetJaacardDistance (string first, string second)
    {
        // Omvandlar strings till char arrays
        var firstArray = first.ToCharArray();
        var secondArray = second.ToCharArray();
        // Omvandlar arrayen till Hashsets som är snabbare
        // se https://www.dotnetcurry.com/csharp/1362/hashset-csharp-with-examples
        var firstSet = new HashSet<char>(firstArray);
        var secondSet = new HashSet<char>(secondArray);
        // Hitta matchande bokstäver (chars)
        var intersection = firstSet.Intersect(secondSet);
        // slår ihop första och andra listan av bokstäver (chars) men bara ett av var sort
        var union = firstSet.Union(secondSet);
        // Dividerar antal likneter med antal bokstäver för att träffsäkerhet i procentuell form
        return (double)intersection.Count() / union.Count();
    }
}
