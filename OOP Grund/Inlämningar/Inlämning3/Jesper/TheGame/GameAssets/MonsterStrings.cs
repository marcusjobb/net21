using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.GameAssets
{
    /// <summary>
    /// A class used to store all the strings used by the various monsters. Stored in arrays to make it easier to get a randomized string.
    /// </summary>
    public class MonsterStrings
    {
        public static string RandomHitMessageText()
        {
            string[] playerHitMessages = {
                "Ow!",
                "Ouchie!",
                "You notice a large red gash on your arm.",
                "You brush it off and prepare to retaliate!",
                "For a brief second you think back to the safety of your camp.."  };
            return playerHitMessages[Game.RandomGenerator.Next(0, playerHitMessages.Length)];
        }

        public static string MonsterGreetingGeneric()
        {
            string[] genericMonsterGreeting = {
                "It lets out a ferocious roar!",
                "It makes a belching noise, ew.",
                "Its intentions are probably not very good.",
                "It looks at you wearily.",
                "It smells of elderberries."
            };
            return genericMonsterGreeting[Game.RandomGenerator.Next(0, genericMonsterGreeting.Length)];
        }
        public static string MonsterGreetingTotallyNotPikachu()
        {
            string[] mouseMonsterGreeting =
            {
                "It screams its own name, over and over again! How odd..",
                "The air is buzzing with electricity!",
                "Your hair stands up due to static electricity, if this game kept track of Charmisma, you'd lose 5 points worth!",
                "It's oddly endearing, a part of you wishes that it could follow you around on whacky adventures."
            };
            return mouseMonsterGreeting[Game.RandomGenerator.Next(0, mouseMonsterGreeting.Length)];
        }
        public static string MonsterGreetingSpookySkeleton()
        {
            string[] spoopySkeletonGreeting =
            {
                "It sends shivers down your spine!",
                "Shrieking skulls will shock your soul!",
                "It speaks with such a screech!",
                "You shake and shudder in surprise!",
                "Out of nowhere you hear the sounds of trumpets playing a catchy melody..",
                "It smiles and scrabbles slowly towards you!",
                "It wakes you with a boo!"
            };
            return spoopySkeletonGreeting[Game.RandomGenerator.Next(0, spoopySkeletonGreeting.Length)];
        }
        public static string MonsterAttackElectricMouse()
        {
            string[] mouseMonsterAttackText =
            {
                "It made a quick attack!",
                "It threw a bolt of thunder towards you, some would say it used thunderbolt!",
                "It zaps you with electricity!",
                "After shouting its own name once again, it whipped you with its tail!",
                "It conjured up a huge wave of water that came crashing down upon you! Wait.. what?"
            };
            return mouseMonsterAttackText[Game.RandomGenerator.Next(0, mouseMonsterAttackText.Length)];
        }

        public static string MonsterDiedText()
        {
            string[] monsterDedText =
            {
                "perished. It reaches for you one last time.",
                "died. Or did it?..",
                "died. You see a hint of sadness in its eyes. You take a moment to reflect on your life.",
                "fainted.",
                "ceased to be."
            };
            return monsterDedText[Game.RandomGenerator.Next(0, monsterDedText.Length)];
        }
    }
}
