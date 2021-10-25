namespace ClassRepetition_20211025
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            //var prlog = new PropertyLogger();
            //prlog.Name = "Marcus";
            //prlog.Name = "Peter";
            //prlog.Name = "Johan";

            string[] vowels1 = { "a", "e", "i", "o", "u" };

            var ings = new List<Ingredient>();
            string input = "";
            do
            {
                Console.WriteLine("Ange ingrediens");
                var ing = new Ingredient();
                input = Console.ReadLine();
                if (input != "q")
                {
                    ing.Name = input;
                    ings.Add(ing);
                }
            } while (input != "q");

            foreach (var item in ings)
            {
                Console.WriteLine(item.Name);
            }

            //var pet=new Pet();
            //pet.Name = "    Voffsing     ";
            //Console.WriteLine(pet);

            //pet.BirthDate = default;
            //Console.WriteLine(pet);

            //var pizza = new Pizza("Capriciosa");
            //pizza.Ingredients.AddRange(
            //new Ingredient[]
            //{
            //    new Ingredient { Name="Ost"},
            //    new Ingredient { Name="Tomat"},
            //    new Ingredient { Name="Svartpeppar"},
            //});

            //// C# 9 kommer att fixa detta med Record
            //var pizza2 = new Pizza("Hawaii", pizza);
            //pizza2.Ingredients.Add(new Ingredient { Name = "Ananas" });

            //foreach (var item in pizza2.Ingredients)
            //{
            //    Console.WriteLine(item);
            //}






            //var box = new Multiclass();

            //var ing1 = new Ingredient();
            //ing1.Name = "Riven ost";
            //ing1.Amount = 1;
            //Ingredient.Info = "Mums!";

            //var ing2 = new Ingredient();
            //ing2.Name = "Tomat";
            //ing2.Amount = 2;
            //Ingredient.Info = "Skivade tomater";

            //Console.WriteLine(ing1);
            //Console.WriteLine(ing2);

            //Person pers = Person.New();
            //pers.Name = "Bruce";
            //pers.LastName = "Wayne";
            //Console.WriteLine(pers.GetWholeName());

        }
    }
}
