namespace DesignPatternsFantasyRPG.ItemCreator.Models
{
    public abstract class Item
    {
        private static int nextId = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RarityEnum Rarity { get; set; }
        
        // Generic value type for items, weapon = damage, Armor = defence points, Potion = heal amount
        public int Value { get; set; }
        
        public Item(string name, string description, RarityEnum rarity) {
            Id = nextId++;
            Name = name;
            Description = description;
            Rarity = rarity;
        }

        public abstract void DisplayInfo();
    }

    public class Weapon : Item
    {
        private WeaponTypeEnum WeaponType { get; set; }

        public Weapon(string name, string description, RarityEnum rarity, WeaponTypeEnum type, int value) : base(name, description, rarity) { 
            WeaponType = type;
            Value = value;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} is a weapon of {Rarity} rarity. Description: {Description}");
        }
    }

    public class Potion : Item
    {
        public Potion(string name, string description, RarityEnum rarity) : base(name, description, rarity) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} is a potion of {Rarity} rarity. Description: {Description}");
        }
    }

    public class Armor : Item
    {
        public Armor(string name, string description, RarityEnum rarity) : base(name, description, rarity) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} is a armor of {Rarity} rarity. Description: {Description}");
        }
    }

    public enum RarityEnum
    {
        Common,
        Magic,
        Rare,
        Legendary
    }

    public enum WeaponTypeEnum
    {
        Melee,
        Ranged
    }
}
