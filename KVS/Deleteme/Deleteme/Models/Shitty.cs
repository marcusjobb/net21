namespace Deleteme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

public class Shitty
{
    [BsonElement("number")]
    public int Number { get; set; }
    public string Name { get; set; } = string.Empty;
    [BsonElement("id")]
    [BsonId]
    public Guid Id { get; set; } = Guid.NewGuid();
    [BsonElement("this_is_sparta")]
    public bool ThisIsSparta { get; set; }
    [BsonElement("this_is_shit")]
    public Shitty ThisIsShit { get; set; } = new();
    [BsonElement("no_this_is_pure_shit")]
    public Shittiast NoThisIsPureShit { get; set; } = new();
}

public class Shittiast
{
}
