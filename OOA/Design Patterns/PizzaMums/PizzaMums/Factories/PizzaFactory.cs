// -----------------------------------------------------------------------------------------------
//  PizzaFactory.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Factories
{
    using PizzaMums.Enums;
    using PizzaMums.Interfaces;
    using PizzaMums.Pizzas;

    // Inspiration https://www.pizzeriamums.se/pizzamenyn/
    // För att de har de bästa pizzorna i Mölndal (i mitt tycke)
    internal static class PizzaFactory
    {
        public static IPizza Bake(PizzaType pizza, bool Glutenfri = false, bool Familjepizza = false)
        {
            IPizza baked = pizza switch
            {
                PizzaType.Buffala => new Buffala(),
                PizzaType.Carpaccio=> new Carpaccio(),
                PizzaType.Chevre=> new Chevre(),
                PizzaType.Diavola => new Diavola(),
                PizzaType.Marguerita => new Marguerita(),
                PizzaType.Parma=> new Parma(),
                PizzaType.Ruccola=> new Ruccola(),
                PizzaType.Tartufo => new Tartufo(),
                PizzaType.Vego => new Vego(),
                _ => new Pizza(),
            };

            if (Glutenfri) baked.Price += 10;
            if (Familjepizza) baked.Price += 75;

            return baked;
        }
    }
}