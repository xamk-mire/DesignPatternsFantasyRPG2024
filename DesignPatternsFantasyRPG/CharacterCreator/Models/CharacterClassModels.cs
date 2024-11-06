namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    // Character model for Warrior class
    public class Warrior : Character
    {
        public Warrior(string name, int health = 150, int mana = 50, int stregth = 100, int agility = 60) : base(name, health, mana, stregth, agility) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Warrior: {Name}, Health: {Health}, Strength: {Strength}, Agility: {Agility}");
        }
    }

    // Character model for Mage class
    public class Mage : Character
    {
        public Mage(string name, int health = 80, int mana = 200, int stregth = 50, int agility = 40) : base(name, health, mana, stregth, agility) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Mage: {Name}, Health: {Health}, Mana: {Mana}, Agility: {Agility}");
        }
    }

    // Character model for Archer class
    public class Archer : Character
    {
        public Archer(string name, int health = 100, int mana = 75, int stregth = 70, int agility = 90) : base(name, health, mana, stregth, agility) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Archer: {Name}, Health: {Health}, Agility: {Agility}, Strength: {Strength}");
        }
    }

    // Character model for NPC
    public class NPC : Character
    {
        public NPC(string name) : base(name, 50, 20, 20, 20) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"NPC: {Name}, Health: {Health}, Agility: {Agility}, Strength: {Strength}");
        }
    }
}
