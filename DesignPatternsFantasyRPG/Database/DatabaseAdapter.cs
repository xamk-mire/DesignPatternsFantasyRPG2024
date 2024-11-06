using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.Database.Models;

namespace DesignPatternsFantasyRPG.Database
{
    public static class CharacterAdapter
    {
        public static CharacterEntity ToEntity(Character character)
        {
            return new CharacterEntity
            {
                Id = character.Id,
                Name = character.Name,
                Health = character.Health,
                Mana = character.Mana,
                Strength = character.Strength,
                Agility = character.Agility,
                CharacterType = character.CharacterType,
            };
        }

        public static Character ToDomainModel(CharacterEntity entity)
        {
            Character character = {};

            // Set the ID
            character.Id = entity.Id;

            return character;
        }
    }
}
