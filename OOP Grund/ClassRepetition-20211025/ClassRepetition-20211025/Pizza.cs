// -----------------------------------------------------------------------------------------------
//  Pizza.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace ClassRepetition_20211025
{
    using System.Collections.Generic;

    class Pizza
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; private set; } // Kan bara sättas från constructorn

        // Constructor
        public Pizza(string name)
        {
            this.Name = name;
            Ingredients = new List<Ingredient>();
        }

        public Pizza (string name, Pizza pizza)
        {
            this.Name = name;
            Ingredients = pizza.Ingredients;
        }

        public Pizza()
        {
            Name = "Margarita";
            Ingredients = new List<Ingredient>();
        }

        public void ChangeName(string name)
        {
            this.Name = name;
        }

    }
}
