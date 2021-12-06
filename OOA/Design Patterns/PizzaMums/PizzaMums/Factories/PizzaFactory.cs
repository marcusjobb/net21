// -----------------------------------------------------------------------------------------------
//  PizzaFactory.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Factories
{
    using PizzaMums.Enums;
    using PizzaMums.Interfaces;
    using PizzaMums.Models;

    internal class PizzaFactory
    {
        public IPizza? Bake (PizzaType pizza)
        {

            IPizza? baked;
            switch (pizza)
            {
                case PizzaType.Marguerita:
                    baked = new Marguerita();
                    break;
                case PizzaType.Vego:
                    baked = new Vego();
                    break;
                case PizzaType.Buffala:
                    baked = new Buffala();
                    break;
                default:
                    baked = null;
                    break;
            }

            return baked;
        }
    }
}
