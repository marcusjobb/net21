// -----------------------------------------------------------------------------------------------
//  Town.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame
{
    using POCO;
    using System;
    using System.Collections.Generic;
    using static Helpers.PrintHelpers;

    internal class Town
    {
        private Player Visitor { get; set; }

        internal string Name { get; set; } = "";

        private readonly float priceMarkUp = 1f;

        internal bool Enter(Player player)
        {
            Visitor = player;
            var leaving = false;
            do
            {
                Menu townmenu = TownHelper.TownMainMenu(Name, Visitor);
                var choice = townmenu.UseMenu();
                if (choice == "Visit the inn.") VisitInn();
                else if (choice == "Visit the equipment store.") VisitEquipmentStore();
                else if (choice == "Show player stats.") Visitor.ShowStats();
                else if (choice == "Exit game.")
                {
                    var sure = new Menu(new List<string> { "Exit game", "Are you sure?", "No.", "Yes." }, 1, 1);
                    var exit = sure.UseMenu();
                    if (exit == "Yes.") return false;
                }
                else leaving = true;
            } while (!leaving);
            LeaveTown();
            return true;
        }

        private static void LeaveTown()
        {
            var description = TownHelper.LeaveTownDesc;
            BorderPrint(description,false);
            Console.ForegroundColor = ConsoleColor.Blue;
            PrintAndHold("Only unexplored rooms can contain monsters...");
            SetColors();
            Console.Clear();
        }

        private void VisitInn()
        {
            var price = 3 * Visitor.Level;
            Menu inn = TownHelper.InnMenu(Visitor, price);
            var choice = inn.UseMenu();
            if (choice.StartsWith("Rest"))
            {
                if (CanAfford(price))
                {
                    Visitor.CurrentHealth = Visitor.MaxHealth;
                    Visitor.Pay(price);
                    BorderPrint("You feel well rested and fully healed after a night at the inn.");
                }
            }
        }

        private void VisitEquipmentStore()
        {
            Menu equipStore = TownHelper.GenerateEquipmentShop(priceMarkUp, Visitor.EquippedWeapon, Visitor.EquippedArmor, Visitor.Purse());
            var leaving = false;

            do
            {
                var choice = equipStore.UseMenu();
                if (choice == "Leave.") leaving = true;
                if (!leaving)
                {
                    var buyString = choice.Substring(0, choice.IndexOf('-') - 1);
                    Item buying = Equipment.EquipmentList.Find(item => item.Name == buyString);
                    var price = (int)(buying.Price * priceMarkUp);
                    if (CanAfford(price))
                    {
                        BuyItem(buying);
                    }
                    equipStore.UpdateMenuItem($"Your current weapon is: {Visitor.EquippedWeapon.Name}", 2);
                    equipStore.UpdateMenuItem($"Your current armor is: {Visitor.EquippedArmor.Name}", 3);
                    equipStore.UpdateMenuItem($"You have {Visitor.Gold} gold coins in your purse.", 4);

                }

            } while (!leaving);
        }

        private void BuyItem(Item item)
        {
            var itemToBuy = item.EffectiveValue;
            var playerWeapon = Visitor.EquippedWeapon.Damage;
            var playerArmor = Visitor.EquippedArmor.Protection;
            var better = (item is Weapon) ? itemToBuy > playerWeapon : itemToBuy > playerArmor;

            if (!better) BorderPrint("You already have the same or better item!");
            else
            {
                BorderPrint($"You bought a {item.Name}.");

                if (item is Weapon weapon) Visitor.EquipWeapon(weapon);
                if (item is Armor armor) Visitor.EquipArmor(armor);

                Visitor.Pay((int)(item.Price * priceMarkUp));
            }
        }

        private bool CanAfford(int price)
        {
            var canAfford = false;
            if (price <= Visitor.Purse()) canAfford = true;
            else BorderPrint("You can't afford that! :(");
            return canAfford;
        }
    }
}
