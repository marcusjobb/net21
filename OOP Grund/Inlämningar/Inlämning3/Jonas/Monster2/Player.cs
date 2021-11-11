using System;
using System.Collections.Generic;
namespace TheGame001
{
    public class Player  : Monster
    {

 
        private int currentMaxHp;
        //private int xp;
        private int level;

        private Weapon usedWeapon;
        private Armor wornArmor;

        private List<Item> equippedItems = new List<Item>();
        //private List<IItem> equippedItems = new List<IItem>();
        //private List<ISEquipable> equippedItems = new List<ISEquipable>();
        public override int HitChance 
        {
            get => hitChance + usedWeapon.ToHitBonus;
            set
            {
 
                hitChance = value;
            }
        }

        public override int HitDamage  
        {
            get => hitDamage + usedWeapon.DamageBonus;
            set
            {
 
                hitDamage = value;
            }
        }

        public int Level
        {
            get => level;
            set
            {
                level = value;
            }
        }

      public Armor WornArmor
        {
            get => wornArmor;
            set
            {
                wornArmor = value;
            }
        }
        public Weapon UsedWeapon
        {
            get => usedWeapon;
            set
            {
                usedWeapon = value;
            }
        }


        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Namn: "+name);
            Console.WriteLine("Level: "+level);
            Console.WriteLine("HP: "+hp+"/"+currentMaxHp);
            Console.WriteLine("XP: "+xp);
            Console.WriteLine("Träffchans: "+hitChance+"% ("+HitChance+"%)");
            Console.WriteLine("Skada: "+hitDamage+" p. ("+HitDamage+" p.)");
            Console.Write("Utrustning: " );
            foreach (var item in inventory)
            {
                Console.Write(item.Name+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("Guld: "+gold);
            Console.WriteLine("Använder Vapen: "+UsedWeapon.Name);
            Console.WriteLine("Bär Rustning: " + WornArmor.Name);
            Console.WriteLine("Använder: ");
            foreach (var item in equippedItems)
            {
                Console.Write(item.Name + " ");
            }

            Console.ReadKey();
            
        }
        public void LevelUp ()
        {
            while (xp / (level * 1000) > 1)
            {
                level++;
                int hitsTaken = currentMaxHp - HP;
                hp = currentMaxHp;
                hp = hp * 6 / 5;
                currentMaxHp = HP;
                hp -= hitsTaken;
                hitDamage = HitDamage * 8 / 7;
                hitChance = HitChance + (100 - hitChance)/5;
                Console.WriteLine(Name + " LEVLADE UPP TILL LEVEL " + level + ", HP är nu " + HP + ", träffchans är nu " + HitChance + "\n"
                    + Name + " gör nu " + HitDamage + " hp skada");
            }
                Console.ReadKey();
            
        }

        public void Consume(Consumable consumable)
        {
            // nånting här

        }

        public void Equip()
        {
            string input = "!";
            int choice;
            do
            {
                Console.WriteLine("använd vad?");
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.Write((i + 1) + " " + inventory[i].Name);
                }
                int.TryParse(Console.ReadLine(), out choice);
                Console.WriteLine("");
                //
                Console.WriteLine(choice);
            } while (!(0 < choice ) ||!( choice <= inventory.Count));
            if (inventory[choice - 1] is Weapon)
            {
 
                Weapon removeMe = (Weapon)inventory[choice - 1];
                Item addMe=null;
 
                //if (usedWeapon != Miscellaneous.ExistingThings["Knytnäve"])
                //{
                     addMe =usedWeapon;
                //}
                usedWeapon = (Weapon)inventory[choice - 1];

                inventory.Remove(removeMe);
                if (addMe != Miscellaneous.ExistingThings["Knytnäve"])
                {
                    inventory.Add(addMe);
                }
            }
            else if (inventory[choice - 1] is Armor)
            {

                Armor removeMe = (Armor)inventory[choice - 1];
                Item addMe = null;

                //if (wornArmor != Miscellaneous.ExistingThings["Bara Mässingen"])
                //{
                    addMe=wornArmor;
                //}
                wornArmor = (Armor)inventory[choice - 1];

                inventory.Remove(removeMe);
                if (addMe != Miscellaneous.ExistingThings["Bara Mässingen"])
                {
                    inventory.Add(addMe);
                }
            }
            else if (inventory[choice - 1] is Consumable)
            {
                //Gör något
            }
            else if (inventory[choice - 1] is Equipable)
            {

                equippedItems.Add( (Equipable) inventory[choice - 1]);
 
                int index = equippedItems.IndexOf( inventory[choice - 1]);
                if(equippedItems[index] is IEquipable spaghetti) 
                {
                    //Console.WriteLine("1 hitDamage är " + hitDamage);
                    //Console.ReadLine();
                    hp = hp + spaghetti.HpBonus;
                    damageReduction += spaghetti.DamageReductionBonus;
                    hitChance += spaghetti.ToHitBonus;
                    hitDamage += spaghetti.Damagebonus;
                    //Console.WriteLine("2 hitDamage är " + hitDamage);
                    //Console.ReadLine();
                }
 
            }
            else
            {
                // Gör ingenting
            }
        }

        public void UnEquip()
        {
            List<Item> TempList = new List<Item>();
            if (wornArmor != Miscellaneous.ExistingThings["Bara Mässingen"]) TempList.Add(wornArmor);
            if (usedWeapon != Miscellaneous.ExistingThings["Knytnäve"]) TempList.Add(usedWeapon);
            foreach (var item in equippedItems)
            {
                TempList.Add((Equipable)item);
            }
            int choice;
            if (TempList.Count > 0)
            {
                do
                {
                    Console.WriteLine("Sluta använda Vad?");
                    for (int i = 0; i < TempList.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + TempList[i].Name);
                    }

                    int.TryParse(Console.ReadLine(), out choice);
                } while (!(0 < choice) || !(choice <= TempList.Count));


                if (TempList[choice - 1] is Armor)
                {
                    inventory.Add(wornArmor);
                    wornArmor = (Armor)Miscellaneous.ExistingThings["Bara Mässingen"];
                }
                else if (TempList[choice - 1] is Weapon)
                {
                    inventory.Add(usedWeapon);
                    usedWeapon = (Weapon)Miscellaneous.ExistingThings["Knytnäve"];
                }
                else if (TempList[choice - 1] is Consumable) // TAG BORT - KAN INTE HÄNDA!
                {
                    //inventory.Add(usedWeapon);
                    //usedWeapon = (Weapon)Miscellaneous.ExistingThings["Knytnäve"];
                }
                else
                {
                    int index = equippedItems.IndexOf(  TempList[choice - 1]);
                    if (equippedItems[index] is IEquipable spaghetti)
                    {
                        hp = hp - spaghetti.HpBonus;
                        damageReduction -= spaghetti.DamageReductionBonus;
                        hitChance -= spaghetti.ToHitBonus;
                        hitDamage -= spaghetti.Damagebonus;
                    }

                    equippedItems.RemoveAt(index);
                }
            }
        }

        public Player (string myName, char sign, int Exp) : base (   myName, sign, Exp)
        {
            Random rnd = new Random();
 
            Weapon Fist = (Weapon)Miscellaneous.ExistingThings["Knytnäve"];
            Armor Shirt = (Armor)Miscellaneous.ExistingThings["Skjorta"];
            Armor BirthDaySuit = (Armor)Miscellaneous.ExistingThings["Bara Mässingen"];
 
            this.position = new int[] { 4, 4 };
            this.hp=rnd.Next(80,120);
            this.xp=0;
            this.currentMaxHp = HP;
            this.hitChance= rnd.Next(10, 35); 
            this.hitDamage = rnd.Next(5, 25); ;
            this.damageReduction=0;
            this.level=1;
            
            this.inventory = new List<Item> { Miscellaneous.ExistingThings["Get"], Miscellaneous.ExistingThings["Svärd"], Miscellaneous.ExistingThings["CocaCola"], Miscellaneous.ExistingThings["Styrkeamulett"] };
            this.gold=55;
            this.usedWeapon = Fist;
            this.wornArmor = Shirt;
        }

    }
}
