namespace Deleteme;

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
