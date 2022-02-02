namespace Deleteme;

using MongoDB.Driver;
// create a CRUD class for Kittens on MongoDB
public class KittenCRUD
{
    // Define database connection
    private readonly MongoClient _client;
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<Kitten> _colKitten;

    public KittenCRUD()
    {
        _client = new MongoClient("mongodb://localhost:27017");
        _database = _client.GetDatabase("Kittens");
        _colKitten = _database.GetCollection<Kitten>("Kittens");
        _colKitten = _database.GetCollection<Kitten>("Kittens");
    }
    public static Kitten ToKitten(Kitten kitten)
    {
        return new Kitten()
        {
            Name = kitten.Name,
            Id = kitten.Id,
            ColorId = kitten.Color.Id,
            KidsId = kitten.Kids.Select(k => k.Id).ToArray()
        };
    }

    public Kitten? Get(Guid id)
    {
        var kitten = _colKitten.Find(k => k.Id == id).FirstOrDefault();
        return kitten == null ? null : KittyTransformer(kitten);
    }
    public Kitten? Get(string name)
    {
        var kitten = _colKitten.Find(c => c.Name == name).FirstOrDefault();
        return KittyTransformer(kitten);
    }

    private Kitten? KittyTransformer(Kitten kitten)
    {
        if(kitten == null)
            return null;
        var color = _database.GetCollection<Color>("Colors").Find(c => c.Id == kitten.ColorId).FirstOrDefault();
        var kidsId = kitten.KidsId.ToArray();
        var kids = _colKitten.AsQueryable<Kitten>().Where(c => kidsId.Contains(c.Id)).ToList();
        kitten.Color = color;
        kitten.Kids = kids;
        return kitten;
    }

    public void Save(Kitten kitten)
    {
        var Kitten = ToKitten(kitten);
        var color = _database.GetCollection<Color>("Colors").Find(c => c.Id == Kitten.ColorId).FirstOrDefault() ?? _database.GetCollection<Color>("Colors").Find(c => c.EyesColor == kitten.Color.EyesColor && c.FurColor == kitten.Color.FurColor && c.TailColor == kitten.Color.TailColor).FirstOrDefault();
        if(color == null)
            _database.GetCollection<Color>("Colors").InsertOne(kitten.Color);
        else
            _ = _database.GetCollection<Color>("Colors").ReplaceOne(c => c.Id == Kitten.ColorId, kitten.Color);

        var kidCollection = _database.GetCollection<Kitten>("Kittens");
        foreach(var kid in kitten.Kids)
        {
            Save(kid);
        }

        var kit = _colKitten.Find(c => c.Id == Kitten.Id).FirstOrDefault() ?? _colKitten.Find(c => c.Name == kitten.Name).FirstOrDefault();
        if(kit == null)
            _colKitten.InsertOne(Kitten);
        else
            _ = _colKitten.ReplaceOne(c => c.Id == Kitten.Id, Kitten);
    }
}
