using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using HtmlAgilityPack;
using System.Xml;

Aftonbladet.ArticleAlt("https://www.aftonbladet.se/nojesbladet/a/1OePbW/melanie-lynskey-hanas-for-sin-vikt-i-yellowjackets");
//var kitten = new KittenBuilder("Bastimisse").SetColor("Black", "Brown", "Black")
//    .AddKid(new KittenBuilder("Bastimissa").SetColor("Black", "Black", "BlackWhite").Build()).Save().Build();

//var cat = new KittenBuilder("Atreyo").Save().Build();
//Console.WriteLine($"{cat.Name}, {cat.Color.EyesColor} {cat.Color.FurColor} {cat.Color.TailColor}");
//cat = new KittenBuilder("Bastimisse").Build();
//Console.WriteLine($"{cat.Name}, {cat.Color.EyesColor} {cat.Color.FurColor} {cat.Color.TailColor}");
//cat = new KittenBuilder("Bastimissa").Build();
//Console.WriteLine($"{cat.Name}, {cat.Color.EyesColor} {cat.Color.FurColor} {cat.Color.TailColor}");

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

public class Kitten

{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public Guid[] KidsId { get; set; }
    public Guid ColorId { get; set; }
    [BsonIgnore]
    public List<Kitten> Kids { get; set; } = new();
    [BsonIgnore]
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

    public Kitten Get(Guid id)
    {
        var kitten = _colKitten.Find(k => k.Id == id).FirstOrDefault();
        if(kitten == null)
        {
            return null;
        }
        return KittyTransformer(kitten);
    }
    public Kitten Get(string name)
    {
        var kitten = _colKitten.Find(c => c.Name == name).FirstOrDefault();
        return KittyTransformer(kitten);
    }

    private Kitten KittyTransformer(Kitten kitten)
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
        var color = _database.GetCollection<Color>("Colors").Find(c => c.Id == Kitten.ColorId).FirstOrDefault();
        if (color==null)
            color = _database.GetCollection<Color>("Colors").Find(c => c.EyesColor == kitten.Color.EyesColor && c.FurColor == kitten.Color.FurColor && c.TailColor== kitten.Color.TailColor).FirstOrDefault();
        if(color == null)
            _database.GetCollection<Color>("Colors").InsertOne(kitten.Color);
        else
            _database.GetCollection<Color>("Colors").ReplaceOne(c => c.Id == Kitten.ColorId, kitten.Color);

        var kidCollection = _database.GetCollection<Kitten>("Kittens");
        foreach(var kid in kitten.Kids)
        {
            Save(kid);
        }

        var kit = _colKitten.Find(c => c.Id == Kitten.Id).FirstOrDefault();
        if(kit == null)
            kit = _colKitten.Find(c => c.Name == kitten.Name).FirstOrDefault();
        if(kit == null)
            _colKitten.InsertOne(Kitten);
        else
            _colKitten.ReplaceOne(c => c.Id == Kitten.Id, Kitten);
    }
}

// create a class that downloads an article from Aftonbladet.se
// and saves it to MongoDB as a document in the database "News"

public class Aftonbladet
{
    public static void ArticleAlt(string url)
    {
        HtmlWeb web = new HtmlWeb();
        HtmlAgilityPack.HtmlDocument doc = web.Load(url);
        string str = doc.DocumentNode.InnerText;
        var pos = str.IndexOf("Tipsa AftonbladetOm Aftonbladet");
        if(pos > 0)
            str = str.Substring(pos+20);
        pos = str.LastIndexOf("Publisert:Publicerad:");
        if(pos > 0)
            str = str.Substring(0, pos);
        Console.WriteLine(str.Trim());
    }
    public static void Article(string url)
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("News");
        var collection = database.GetCollection<BsonDocument>("Aftonbladet");

        var web = new HtmlWeb();
        var doc = web.Load(url);

        var test = doc.DocumentNode.SelectNodes("//div[@class='observer-placeholder']");


        var article = new BsonDocument();
        article["Title"] = doc.DocumentNode.SelectSingleNode("//title").InnerText;
        article["Content"] = doc.DocumentNode.SelectSingleNode("//div[@class='article-body']").InnerText;
        article["Date"] = doc.DocumentNode.SelectSingleNode("//time[@class='article-date']").InnerText;
        article["Author"] = doc.DocumentNode.SelectSingleNode("//span[@class='article-author']").InnerText;
        article["Url"] = url;
        article["Id"] = Guid.NewGuid();

        collection.InsertOne(article);
    }
}