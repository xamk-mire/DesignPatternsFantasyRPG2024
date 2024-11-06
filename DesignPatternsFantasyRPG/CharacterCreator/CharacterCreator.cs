using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.Enums;
using System.Drawing;

namespace DesignPatternsFantasyRPG.CharacterCreator
{
    public abstract class CharacterFactory
    {
        public abstract Character CreatePlayerCharacter(CharacterTypeEnum type, string name, int health, int mana);
        public abstract Character CreateNPC(NPCTypeEnum type, string name, int health, int mana);
        public abstract Character CreateEnemy(EnemyTypeEnum type, string name, int health, int mana);
    }

    // Character creator factory
    public class CharacterCreatorFactory : CharacterFactory
    {
        public override Character CreatePlayerCharacter(CharacterTypeEnum type, string name, int health, int mana)
        {
            switch (type)
            {
                case CharacterTypeEnum.Warrior:
                    return new Warrior(name, health, mana);
                case CharacterTypeEnum.Mage:
                    return new Mage(name, health, mana);
                case CharacterTypeEnum.Archer:
                    return new Mage(name, health, mana);
                default:
                    throw new ArgumentException("Invalid character type.");
            }
        }

        public override Character CreateNPC(NPCTypeEnum type, string name, int health, int mana)
        {
            switch (type)
            {
                case NPCTypeEnum.Villager:
                    return new Villager(name, health, mana);
                case NPCTypeEnum.Merchant:
                    return new Merchant(name, health, mana);
                default:
                    throw new ArgumentException("Invalid npc type.");
            }
        }

        public override Character CreateEnemy(EnemyTypeEnum type, string name, int health, int mana)
        {
            switch (type)
            {
                case EnemyTypeEnum.Slime:
                    return new Slime(name, health, mana);
                case EnemyTypeEnum.Goblin:
                    return new Goblin(name, health, mana);
                case EnemyTypeEnum.Orc:
                    return new Orc(name, health, mana);
                case EnemyTypeEnum.Dragon:
                    return new Dragon(name, health, mana);
                default:
                    throw new ArgumentException("Invalid enemy type.");
            }
        }
    }
}
