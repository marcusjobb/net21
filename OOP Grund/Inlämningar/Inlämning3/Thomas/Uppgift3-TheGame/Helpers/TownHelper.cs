// -----------------------------------------------------------------------------------------------
//  TownHelper.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.POCO
{
    using System.Collections.Generic;
    using static POCO.Equipment;

    internal static class TownHelper
    {
        internal static string[] LeaveTownDesc =
        {
            "You head out of town into the Evershifting Maze,",
            "the mystical, magical domain that surrounds your",
            "masters lair. Your task is to hunt down and kill",
            "invading so-called heroes who's always poking around",
            "and trying to kill all the \"innocent\" minions and",
            "rob your master of his ill-gotten spoils.",
            "",
            "Luckily you have your trusty portal stone with you so",
            "you can alway return to town at will.",
            "Good luck and happy hunting!"
        };
        internal static Menu TownMainMenu(string name, Player visitor)
        {
            List<string> tmm = new()
            {
                $"Welcome to {name}",
                "The place is bustling and there are several places to visit;",
                "but adventure calls, maybe you should just head out again?",
                $"Health {visitor.CurrentHealth} / {visitor.MaxHealth}, Gold: {visitor.Purse()}",
                $"Weapon: {visitor.EquippedWeapon.Name}",
                $"Armor: {visitor.EquippedArmor.Name}",
                "Head out on new adventures.",
                "Show player stats.",
                "Visit the inn.",
                "Visit the equipment store.",
                "Exit game."
            };
            return new Menu(tmm, 3, 3);
        }

        internal static Menu GenerateEquipmentShop(float markUp, Weapon equippedWeapon, Armor equippedArmor, int gold)
        {
            List<string> aShopList = new() { "Welcome to the armor store!", "What would you like to buy today?" };
            aShopList.Add($"Your current weapon is: {equippedWeapon.Name}");
            aShopList.Add($"Your current armor is: {equippedArmor.Name}");
            aShopList.Add($"You have {gold} gold coins in your purse.");
            foreach (Item item in EquipmentList)
            {
                aShopList.Add($"{item.Name} - {(int)(item.Price * markUp)} gold.");
            }
            aShopList.Add("Leave.");

            return new Menu(aShopList, 2, 3);
        }

        internal static Menu InnMenu(Player player, int price)
        {
            List<string> innList = new()
            {
                "Welcome to the inn!",
                "Would you like to stay the night?",
                $"Current health : {player.CurrentHealth} / {player.MaxHealth}",
                $"You have {player.Gold} gold.",
                $"Rest until fully healed - {price} gold",
                "Leave"
            };
            Menu inn = new(innList, 2, 2);
            return inn;
        }



    }
}
