using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.GameStructure;
using TheGame.GameStructure.ShopItems;
using static TheGame.DisplayMethods.Display;
using static TheGame.Helpers.StringHelpers;
using static TheGame.Helpers.UserExperience;
using static TheGame.GameAssets.StoryStrings;
using static TheGame.GameAssets.ArtAssets;

namespace TheGame.GameStructure
{
    public class Shop
    {
        // A ShopItem list and 3 separate ShopItems are declared.
        internal List<ShopItem> ShopItemsList;
        internal ShopItem RandomItem1;
        internal ShopItem RandomItem2;
        internal ShopItem RandomItem3;

        /// <summary>
        /// The constructor is used to populate the list with random items when the class is created. There might be a more appropriate way of doing this but it seems to work fine for this simple game.
        /// Each previously declared ShopItem is assigned a random ShopItem by the RandomizeItem function. 
        /// Each time the shop is created (when the player visits it) these items will be different. The items are then added to the list.
        /// </summary>
        public Shop()
        {
            RandomItem1 = ItemRandomizer.RandomizeItem();
            RandomItem2 = ItemRandomizer.RandomizeItem();
            RandomItem3 = ItemRandomizer.RandomizeItem();

            ShopItemsList = new List<ShopItem>
            {
                RandomItem1,
                RandomItem2,
                RandomItem3
            };
        }

        /// <summary>
        /// The "main menu" of the shop, where the player can purchase items.
        /// </summary>
        /// <param name="currentPlayer"></param>
        internal void ShopMenu(Player currentPlayer)
        {
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                CenterWriteLineColour(textShop, ConsoleColor.DarkYellow);
                WriteLineColour(merchantArt, ConsoleColor.DarkMagenta);
                CenterWriteLine(RandomMerchantGreeting());
                List<string> shopMenu = new List<string> {
                    "[1] See what the merchant has in store",
                    "[2] Leave the shop and return to camp\n"};
                MiddleWriteLines(shopMenu);
                CursorPosition(18, 42);
                int.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        ChooseItemToBuy(ShopItemsList, currentPlayer);
                        break;
                    case 2:
                        Console.WriteLine("You walk out of the shop.");
                        showMenu = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        /// <summary>
        /// A minimenu which lets the player view all the items, and then press a corresponding button to buy the chosen item.
        /// In order to avoid an IndexOutOfRange error, each case first checks if the selected choice is less than the amount of elements in the list. There might be a better solution.
        /// </summary>
        /// <param name="itemsForSale"></param>
        /// <param name="currentPlayer"></param>
        private void ChooseItemToBuy(List<ShopItem> itemsForSale, Player currentPlayer)
        {
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                WriteLineColour(textBrowse, ConsoleColor.DarkYellow);
                WriteLineColour(shopBrowseBackground, ConsoleColor.DarkYellow);
                ShowMerchantItems(itemsForSale);
                Console.WriteLine();
                CenterWriteLine($"You have {currentPlayer.Gold} gold to spend.\n");
                Console.WriteLine();
                CenterWriteLine("Press [Enter] to quit browsing.");
                CursorPosition(17, 59);
                int.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        if (menuChoice <= itemsForSale.Count)
                            PurchaseThisItem(itemsForSale, itemsForSale[0], currentPlayer);
                        break;
                    case 2:
                        if (menuChoice <= itemsForSale.Count)
                            PurchaseThisItem(itemsForSale, itemsForSale[1], currentPlayer);
                        break;
                    case 3:
                        if (menuChoice <= itemsForSale.Count)
                            PurchaseThisItem(itemsForSale, itemsForSale[2], currentPlayer);
                        break;
                    default:
                        showMenu = false;
                        break;
                }
            }
        }

        /// <summary>
        /// This is where the actual purchase of the item happens. The list, item, and player gets sent into the method, since they all need to be edited.
        /// The list gets the chosen item removed, and the player loses however much gold the item was worth. And the player stats gets updated.
        /// Do note that the player doesn't actually "get" an item, but instead pays for the attribute increase.
        /// </summary>
        /// <param name="itemList"></param>
        /// <param name="item"></param>
        /// <param name="currentPlayer"></param>
        private void PurchaseThisItem(List<ShopItem> itemList, ShopItem item, Player currentPlayer)
        {
            CenterWriteLine($"Do you want to purchase {item.Name} for {item.GoldCost} gold?");
            var userAnswer = QuestionAndAnswerPosition("Press[Y] for \"YES\"", 20, 59);
            CursorPosition(17, 59);
            if (userAnswer.ToLower() == "y")
            {
                if (currentPlayer.Gold < item.GoldCost)
                {
                    Console.Clear();
                    MiddleWriteLine("");
                    CenterWriteLineColour("You cannot afford this item!", ConsoleColor.DarkRed);
                    CenterPressEnterToContinue();
                }
                else
                {
                    Console.Clear();
                    MiddleWriteLine("");
                    CenterWriteLineColour("Item purchased!", ConsoleColor.DarkYellow);
                    UpdatePlayerGold(item, currentPlayer);
                    ItemPurchasedUpdatesStats(item, currentPlayer);
                    itemList.Remove(item);
                    CenterPressEnterToContinue();
                }
            }
        }

        // Loops through the array and displays the items. 
        private void ShowMerchantItems(List<ShopItem> shopItems)
        {
            List<string> centeredList = new();
            
            for (int i = 0; i < shopItems.Count; i++)
            {
                ShopItem item = shopItems[i];
                centeredList.Add($"[{i + 1}] - {item.Name}. (+{item.StatValue} {item.StatType}) - Costs: {item.GoldCost} gold.");
            }
            MiddleWriteLines(centeredList);
        }

        // If the name of the purchased item contains certain letters, it gets matched with the corresponding playerstat, this allows for easier updating of the stats. 
        // TODO: There may be a better solution, this solution was created early on but it still works.
        private void ItemPurchasedUpdatesStats(ShopItem purchasedItem, Player currentPlayer)
        {
            if (purchasedItem.StatType.ToLower().Contains("str"))
            {
                currentPlayer.Strength += purchasedItem.StatValue;
            }
            if (purchasedItem.StatType.ToLower().Contains("tou"))
            {
                currentPlayer.Toughness += purchasedItem.StatValue;
            }
        }

        // The player uses its GiveGold method to pay for the item.
        private void UpdatePlayerGold(ShopItem item, Player currentPlayer)
        {
            currentPlayer.GiveGold(item.GoldCost);
        }
    }
}
