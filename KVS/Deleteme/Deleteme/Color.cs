using MongoDB.Bson.Serialization.Attributes;
namespace Deleteme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Color
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FurColor { get; set; }
    public string EyesColor { get; set; }
    public string TailColor { get; set; }
}
