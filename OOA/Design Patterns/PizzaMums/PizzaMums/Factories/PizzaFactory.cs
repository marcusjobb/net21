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
    internal static class PizzaFactory
    {
        public static IPizza Bake(PizzaType pizza, bool Glutenfri = false, bool Familjepizza = false)
        {
            IPizza baked = pizza switch
            {
                PizzaType.Marguerita => new Marguerita(),
                PizzaType.Vego => new Vego(),
                PizzaType.Buffala => new Buffala(),
                PizzaType.Chevre=> new Chevre(),
                PizzaType.Carpaccio=> new Carpaccio(),
                PizzaType.Tartufo=> new Tartufo(),
                _ => new Pizza(),
            };

            if (Glutenfri) baked.Price += 10;
            if (Familjepizza) baked.Price += 75;

            return baked;
        }
    }
}