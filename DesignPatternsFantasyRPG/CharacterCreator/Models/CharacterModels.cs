namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    public abstract class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        protected Character(string name, int health, int mana, int strength, int agility)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Strength = strength;
            Agility = agility;
        }

        public abstract void DisplayInfo();
    }
}
