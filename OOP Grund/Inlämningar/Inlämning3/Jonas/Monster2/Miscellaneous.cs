using System;
using System.Collections.Generic;


namespace TheGame001
{
    public static class Miscellaneous
    {
        static Random rand = new Random();


        public static Dictionary<string, Item> ExistingThings = new Dictionary<string, Item>()
        {
            { "Get", new Item { Name = "Get", SuggestedPrice = 1, Description = "En värdelös get. Bäää!" }},
            { "Knytnäve", new Weapon {Name ="Knytnäve", SuggestedPrice=0, Description="Kilroy was here", DamageBonus=1, ToHitBonus=1, Sellable=false} },
            { "Dolk",new Weapon {Name ="Dolk", SuggestedPrice=20, Description="En dolk. +5 skada. Hugg med den spetsiga änden", DamageBonus=5, ToHitBonus=0, Sellable=true}},
            { "Svärd",new Weapon {Name ="Svärd", SuggestedPrice=150, Description="Ett svärd. +20 skada", DamageBonus=20, ToHitBonus=0, Sellable=true}},
            { "Yxa",new Weapon {Name ="Yxa", SuggestedPrice=100, Description="En yxa. +40 skada, -20 träffchans", DamageBonus=40, ToHitBonus=-20, Sellable=true}},
            { "Bara Mässingen",new Armor {Name ="Bara Mässingen", SuggestedPrice=1, Description="Kilroy Was here",  ToHitBonus=0, DamageReductionBonus=0}},         //ge armor SellablePropsen och sätt till false
            { "Skjorta",new Armor {Name ="Skjorta", SuggestedPrice=1, Description="En skjorta - the shirt off your back.",  ToHitBonus=0, DamageReductionBonus=1}},
            { "Läderrustning",new Armor {Name ="Läderrustning", SuggestedPrice=50, Description="Läderställ med Hells-Angels-logga. +5 skadereduktion ",  ToHitBonus=0, DamageReductionBonus=5}},
            { "Ringbrynja",new Armor {Name ="Ringbrynja", SuggestedPrice=100, Description="Ringbrynja. +20 skadereduktion",  ToHitBonus=0, DamageReductionBonus=20}},
            { "Kyrass",new Armor {Name ="Kyrass", SuggestedPrice=250, Description="Ett harnesk av 3mm stålplåt S255JR. -20 träffchans, +40 skadereduktion",  ToHitBonus=-20, DamageReductionBonus=0}},
            { "Styrkeamulett",new Equipable {Name ="Styrkeamulett", SuggestedPrice=50, Description="Ett förtrollat simborgarmärke. +5 skada.",  ToHitBonus=0, DamageReductionBonus=0, HpBonus=0, Damagebonus=5}},
            { "Hälsoamulett",new Equipable {Name ="Hälsoamulett", SuggestedPrice=50, Description="Gammalt \"kärnkraft- nej tack\" - märke med stark hippie-magi. +5 hp.",  ToHitBonus=0, DamageReductionBonus=0, HpBonus=5, Damagebonus=0}},
            { "CocaCola",new Consumable {Name ="CocaCola", SuggestedPrice=50, Description="CocaCola - It's the real thing! +20 hp i 20 rundor",  ToHitBonus=0, DamageReductionBonus=0, HpBonus=20, Damagebonus=0, Duration=20}},
            { "PepsiCola",new Consumable {Name ="PepsiCola", SuggestedPrice=50, Description="PepsiCola - The Choice of a New Generation! +20 skada i 20 rundor",  ToHitBonus=0, DamageReductionBonus=0, HpBonus=5, Damagebonus=20, Duration=20}}
        };
        public static List<Item> AllTheThings = FillTheList();

        //public static List<Monster> GenericMonsterTemplates = new List<Monster>
        //{
        //    new Monster("minitaur", 'm') {XP=250,HP=rand.Next(30,80)},
        //};

        private static List<Item> FillTheList()
        {
            //List<string> KeyList = new List<string>();
            List<Item> ReturnMe = new List<Item>();
            //for (int i = 0; i < ExistingThings.Count; i++)
            foreach (var item in ExistingThings)
            {
                //KeyList.Add(item.Key);
                ReturnMe.Add(item.Value);
            }
            return ReturnMe;
        }


    }

}





