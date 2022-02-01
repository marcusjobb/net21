using System.Globalization;
using System.ComponentModel.DataAnnotations;

using MongoDB.Driver;
using MongoDB.Bson;

var kitten = new KittenBuilder("Bastimisse")
    .SetColor("Black", "Brown", "Black")
    .AddKid(new KittenBuilder("Bastimissa").SetColor("Black", "Black", "BlackWhite").Build());
kitten.Save();

kitten = new KittenBuilder("Atreyo").SetColor("Striped grey","green");
kitten.Save();

Console.WriteLine(kitten.Build().Name);

// Create a builder class for Kittens

public class KittenBuilder
{
    Kitten myKitten = new();
    KittenCRUD crud = new();
    public KittenBuilder()
    {

    }
    public KittenBuilder(string name)
    {
        var kitten = crud.Get(name);

        if(kitten == null)
        {
            myKitten = new Kitten();
            myKitten.Name = name;
        }
        else
        {
            myKitten = kitten;
        }
    }
    public KittenBuilder(Guid id)
    {
        var kitten = crud.Get(id);

        if(kitten == null)
        {
            myKitten = new Kitten();
            myKitten.Id = id;
        }
        else
        {
            myKitten = kitten;
        }
    }

    public KittenBuilder SetName(string name)
    {
        myKitten.Name = name;
        return this;
    }

    public KittenBuilder SetColor(string fur, string eyes)
    {
        myKitten.Color.FurColor = fur;
        myKitten.Color.EyesColor = eyes;
        myKitten.Color.TailColor = fur;
        return this;
    }
    public KittenBuilder SetColor(string fur, string eyes, string tail)
    {
        myKitten.Color.FurColor = fur;
        myKitten.Color.EyesColor = eyes;
        myKitten.Color.TailColor = tail;
        return this;
    }

    public KittenBuilder AddKid(Kitten kid)
    {
        myKitten.Kids.Add(kid);
        return this;
    }

    public Kitten Build()
    {
        return myKitten;
    }

    public KittenBuilder Save()
    {
        crud.Save(myKitten);
        return this;
    }


}

public class KittenDB 
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public Guid[] KidsId { get; set; }
    public Guid ColorId { get; set; }
}
public class Kitten
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public List<Kitten> Kids { get; set; } = new();
    public Color Color { get; set; } = new();
}

public class Color
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FurColor { get; set; }
    public string EyesColor { get; set; }
    public string TailColor { get; set; }
}

// create a CRUD class for Kittens on MongoDB
public class KittenCRUD
{
    // Define database connection
    private readonly MongoClient _client;
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<KittenDB> _colKittenDB;
    private readonly IMongoCollection<Kitten> _colKitten;

    public KittenCRUD()
    {
        _client = new MongoClient("mongodb://localhost:27017");
        _database = _client.GetDatabase("Kittens");
        _colKittenDB = _database.GetCollection<KittenDB>("Kittens");
        _colKitten = _database.GetCollection<Kitten>("Kittens");
    }
    public static KittenDB ToKittenDB(Kitten kitten)
    {
        return new KittenDB()
        {
            Name = kitten.Name,
            Id = kitten.Id,
            ColorId = kitten.Color.Id,
            KidsId = kitten.Kids.Select(k => k.Id).ToArray()
        };
    }

    public Kitten Get(Guid id)
    {
        var kitten = _colKittenDB.Find(k => k.Id == id).FirstOrDefault();
        if(kitten == null)
        {
            return null;
        }
        return KittyTransformer(kitten);
    }
    public Kitten Get(string name)
    {
        var kitten = _colKittenDB.Find(c => c.Name == name).FirstOrDefault();
        return KittyTransformer(kitten);
    }

    private Kitten KittyTransformer(KittenDB kitten)
    {
        if(kitten == null)
            return null;
        var color = _database.GetCollection<Color>("Colors").Find(c => c.Id == kitten.ColorId).FirstOrDefault();
        var kidsId = kitten.KidsId.ToArray();
        var kids = _colKitten.AsQueryable<Kitten>().Where(c => kidsId.Contains(c.Id)).ToList();
        return new Kitten()
        {
            Name = kitten.Name,
            Id = kitten.Id,
            Color = color,
            //Kids = new List<Kitten>(kids)
        };
    }

    public void Save(Kitten kitten)
    {
        var kittenDb = ToKittenDB(kitten);
        var color = _database.GetCollection<Color>("Colors").Find(c => c.Id == kittenDb.ColorId).FirstOrDefault();
        if (color==null)
            color = _database.GetCollection<Color>("Colors").Find(c => c.EyesColor == kitten.Color.EyesColor && c.FurColor == kitten.Color.FurColor && c.TailColor== kitten.Color.TailColor).FirstOrDefault();
        if(color == null)
            _database.GetCollection<Color>("Colors").InsertOne(kitten.Color);
        else
            _database.GetCollection<Color>("Colors").ReplaceOne(c => c.Id == kittenDb.ColorId, kitten.Color);

        var kidCollection = _database.GetCollection<KittenDB>("Kittens");
        foreach(var kid in kitten.Kids)
        {
            Save(kid);
        }

        var kit = _colKittenDB.Find(c => c.Id == kittenDb.Id).FirstOrDefault();
        if(kit == null)
            kit = _colKittenDB.Find(c => c.Name == kitten.Name).FirstOrDefault();
        if(kit == null)
            _colKittenDB.InsertOne(kittenDb);
        else
            _colKittenDB.ReplaceOne(c => c.Id == kittenDb.Id, kittenDb);
    }
}