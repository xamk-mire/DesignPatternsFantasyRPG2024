using DesignPatternsFantasyRPG.Enums;

namespace DesignPatternsFantasyRPG.Database.Models
{
    public class CharacterEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public CharacterTypeEnum CharacterType { get; set; }
    }
}
