using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.GameAssets
{
    /// <summary>
    /// Stores all the "story" related strings. Stored in arrays and return a random string from each respective array. Used to make the game text less repetitive.
    /// </summary>
    public class StoryStrings
    {
        
        public static string RandomTipsText()
        {
            string[] playerTips = {
                "Hint: Don't forget to visit the shop to get better equipment!", 
                "Hint: With great power comes great responsibility, and also don't forget to buy items from the shop." ,
                "Hint: Finding life difficult? Stop by your local camp merchant to upgrade your stats!",
                "Hint: Is it technically pay to win if you buy items with ingame gold? (Nudge nudge, wink wink).",
                "Hint: Some speak of a legendary \"1337\" Warrior.."
            };
            return playerTips[Game.RandomGenerator.Next(0, playerTips.Length)];
        }

        public static string RandomGameWonText()
        {
            string[] GameWon = {
                "You are victorious! Who knows what other challenges lies ahead.",
                "Congratulations, you have won the game!",
                "Winner winner chicken dinner!"
            };
            return GameWon[Game.RandomGenerator.Next(0, GameWon.Length)];
        }

        public static string RandomLeaveCampText()
        {
            string[] leaveCampText = {
                "You leave the camp and set out on your adventure..\n",
                "You stock up on rations and leave the camp.. Home is behind, the World ahead.\n",
                "You take a swig of the merchants newly brewed potion as you leave camp. Bitter.. \n",
                "Feeling refreshed after a good nights sleep, you leave the camp in search of adventure.\n",
                "Rumours have it there's some kind of beast plaguing the nearby village, you grab your sword and leave camp..\n"
            };
            return leaveCampText[Game.RandomGenerator.Next(0, leaveCampText.Length)];
        }
        public static string RandomEncounterGrassText()
        {
            string[] encounterGrassText = {
                "You look around you and see nothing but grass swaying in the wind.. You return to camp.\n",
                "The morning mist clears, revealing an empty glade.. Wind's howling. You return to camp.\n",
                "Everything seems calm. You hear branches snapping in the distance.. You return to camp.\n",
                "You suddenly realise that you left your sword back at camp.. You return to camp.\n"
            };
            return encounterGrassText[Game.RandomGenerator.Next(0, encounterGrassText.Length)];
        }

        public static string RandomEncounterCombat()
        {
            string[] encounterCombatText = {
                "You hear distant footsteps rapidly closing in on your position. You draw your sword and stand ready..\n",
                "You see movement ahead. You steel yourself for what's about to come as you press onwards..\n" ,
                "You feel as if someone or something is watching.. You place your hand on your sword.\n",
                "You feel uneasy. As you peer through the vegetation you spot a pair of bright red eyes. Suddenly, they disappear..\n"
            };
            return encounterCombatText[Game.RandomGenerator.Next(0, encounterCombatText.Length)];
        }

        public static string RandomCombatIntro()
        {
            string[] combatAboutToStart = {
                "Something emerges out of the shadows!\n",
                "Something runs into you, knocking you down! You get up and turn around..\n" ,
                "The foliage parts in front of you.. Here it comes!\n",
                "A strike of lightning appears in front of you! The smoke and dust clear revealing a shadowy figure..\n"
            };
            return combatAboutToStart[Game.RandomGenerator.Next(0, combatAboutToStart.Length)];
        }

        public static string RandomGameIntroText()
        {
            string[] gameText = {
                "\t\tYou awaken in your camp. The embers in the fireplace are still smoldering from the night before.\n\t\t\t\t\t\tJust as the smoke, you rise.\n",
                "\t\tYou lay awake on your bedroll for a moment, watching as the clouds slowly part in the sky above.\n\t\t\t\t\tYou make your way out into the camp.\n" ,
                "\t\t\tYou awaken to the smell of freshly brewed coffee in the cold morning air.\n\t\t\t   You make your way out into the camp to greet your companions.\n"
            };
            return gameText[Game.RandomGenerator.Next(0, gameText.Length)];
        }

        public static string RandomMerchantGreeting()
        {
            string[] merchantGreeting = {
                "\"Greetings Traveler!\" - The merchant says as he motions to his wares\n",
                "\"Ahoy there! \" - The merchant says, what a guy.\n",
                "\"Stay a while, and listen.\"  - The merchant says with a grim look on his face.\n",
                "\"Please, have a gander\" - The merchant motions towards his wares.\n"
            };
            return merchantGreeting[Game.RandomGenerator.Next(0, merchantGreeting.Length)];
        }

        public static string PlayerAttackText()
        {
            string[] playerAttackText = {
                    "You dodge and strike gracefully!",
                    "You lunge forwards with great speed!" ,
                    "After a quick flourish, you swiftly strike!",
                    "The sword sings in your hand!",
                    "You can almost feel your sword thirsting for more",
                    "You inflicted a grievous wound!"
                };
            return playerAttackText[Game.RandomGenerator.Next(0, playerAttackText.Length)];
        }
        //public static string PlaceholderRename()
        //{
        //    string[] placeholderRename = {
        //        "",
        //        "" ,
        //        ""
        //    };
        //    return placeholderRename[Game.RandomGenerator.Next(0, placeholderRename.Length)];
        //}
    }
}
