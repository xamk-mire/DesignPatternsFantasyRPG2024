using DesignPatternsFantasyRPG.Enums;

namespace DesignPatternsFantasyRPG.ItemCreator.Models
{
    public abstract class Item
    {
        private static int nextId = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RarityEnum Rarity { get; set; }
        public ItemTypeEnum ItemType { get; set; }

        // Item specific value, weapon = damage, potion = heal amount, armor = defence score
        public int ItemValue { get; private set; }


        public Item(string name, string description, RarityEnum rarity, int itemValue = 0)
        {
            Id = nextId++;
            Name = name;
            Description = description;
            Rarity = rarity;
            ItemValue = itemValue;
        }

        public abstract void DisplayInfo();
    }

    public class Weapon : Item
    {
        public WeaponTypeEnum WeaponType { get; private set; }

        public Weapon(string name, string description, RarityEnum rarity, WeaponTypeEnum type, int itemValue) : base(name, description, rarity, itemValue) { 
            WeaponType = type;
            ItemType = ItemTypeEnum.Weapon;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} is a weapon of {Rarity} rarity. Description: {Description}");
        }
    }

    public class Potion : Item
    {
        public Potion(string name, string description, RarityEnum rarity, int itemValue) : base(name, description, rarity, itemValue) {
            ItemType = ItemTypeEnum.Utility;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} is a potion of {Rarity} rarity. Description: {Description}");
        }
    }

    public class Armor : Item
    {
        public Armor(string name, string description, RarityEnum rarity, int itemValue) : base(name, description, rarity, itemValue)
        {
            ItemType = ItemTypeEnum.Defensive;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} is a armor of {Rarity} rarity. Description: {Description}");
        }
    }

    
}
