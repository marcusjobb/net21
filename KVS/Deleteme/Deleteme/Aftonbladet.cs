namespace Leech;
using MongoDB.Driver;
using MongoDB.Bson;
using HtmlAgilityPack;
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
            str = str[(pos + 20)..];
        pos = str.LastIndexOf("Publisert:Publicerad:");
        if(pos > 0)
            str = str[..pos];
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