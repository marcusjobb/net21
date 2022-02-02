namespace Deleteme.Models;

using System;
using MongoDB.Bson.Serialization.Attributes;

public class Shitty
{
    [BsonId]
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = string.Empty;

    [BsonElement("no_this_is_pure_shit")]
    public Shittiast NoThisIsPureShit { get; set; } = new();

    [BsonElement("number")]
    public int Number { get; set; }

    [BsonElement("this_is_shit")]
    public Shitty ThisIsShit { get; set; } = new();

    [BsonElement("this_is_sparta")]
    public bool ThisIsSparta { get; set; }
}

public class Shittiast
{
}
