namespace Deleteme;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Kitten

{
    public ObjectId MyKey { get; set; } = ObjectId.GenerateNewId();
    
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public Guid[] KidsId { get; set; }
    public Guid ColorId { get; set; }
    [BsonIgnore]
    public List<Kitten> Kids { get; set; } = new();
    [BsonIgnore]
    public Color Color { get; set; } = new();
}
