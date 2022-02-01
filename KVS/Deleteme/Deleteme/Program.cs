// open connection to Kitten database on MongoDB localhost

// Create a builder class for Kittens
using MongoDB.Driver;

public class KittenBuilder
{
    Kitten myKitten = new();
    public string DBName { get; set; } = "Kittens";
    public string Collection { get; set; } = "Kittens";
    public string ConnectionString { get; set; } = "MongoDB://localhost:27017";

    public Kittenbuilder(string name)
    {
        // Fetch the kitten from MongoDB or create a new one
        var client = new MongoClient(ConnectionString);
        var database = client.GetDatabase(DBName);
        var collection = database.GetCollection<Kitten>(collection);
        var kitten = collection.Find(c => c.Name == name).FirstOrDefault();
        if (kitten == null)
        {
            kitten = new Kitten();
            kitten.Name = name;
        }
    }
    public Kittenbuilder(Guid id)
    {
        // Fetch the kitten from MongoDB or create a new one
        var client = new MongoClient(ConnectionString);
        var database = client.GetDatabase(DBName);
        var collection = database.GetCollection<Kitten>(collection);
        var myKitten = collection.Find(c => c.Id == id).FirstOrDefault();
        if (myKitten == null)
        {
            myKitten = new Kitten();
            myKitten.Id = id;
        }
    }

    public KittenBuilder SetName(string name)
    {
        myKitten.Name = name;
        return this;
    }

    public KittenBuilder SetColor(string fur, string eyes, string tail)
     {
        myKitten.FurColor = fur;
        myKitten.EyesColor = eyes;
        myKitten.TailColor = tail;
        return this;
    };

    public KittenBuilder AddKid(Kitten kid)
    {
        myKitten.Kids.Add(kid);
        return this;
    }

    public Kitten Build()
    {
        // convert kitten to KittenDB format then
        // update or save kitten data to MongoDB
        var client = new MongoClient(ConnectionString);
        var database = client.GetDatabase(DBName);
        var collection = database.GetCollection<KittenDB>(collection);
        var kittenDb = ToKittenDB(myKitten);

        return myKitten;
    }

public static KittenDB ToKittenDB(Kitten kitten)
    {
        return new KittenDB()
        {
            Name = kitten.Name,
            Id = kitten.Id,
            Color = kitten.Color,
            Kids = kitten.Kids,
            ColorId = kitten.Color.Id,
            KidsId = kitten.Kids.Select(k => k.Id).ToArray()
        };

    public static Kitten ToKitten(KittenDB kitten)
    {
        return new Kitten()
        {
            Name = kitten.Name,
            Id = kitten.Id,
            Color = kitten.Color,
            Kids = kitten.Kids,
            //ColorId = kitten.Color.Id,
            //KidsId = kitten.Kids.Select(k => k.Id).ToArray()
        };
    }
    }
}

class KittenDB:Kitten
{
    public Guid[] KidsId { get; set; }
    public Guid ColorId { get; set; }
}
class Kitten
{
    public Guid Id { get; set; }= Guid.NewGuid();
    public string Name { get; set; } = "";
    public List<Kitten> Kids { get; set; } = new();
    public Color Color { get; set; } = new();
}

public class Color 
{
    public Guid Id { get; set; }
    public string FurColor { get; set; }
    public string EyeColor { get; set; }
    public string TailColor { get; set; }
}

