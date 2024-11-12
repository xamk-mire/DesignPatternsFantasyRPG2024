using DesignPatternsFantasyRPG.CharacterCreator.Models;

namespace DesignPatternsFantasyRPG.CommandHandler.Models
{
    public class AttackCommand : ICommand
    {
        private readonly Character _character;
        private readonly Character _target;

        public AttackCommand(Character character, Character target)
        {
            _character = character;
            _target = target;
        }

        public void Execute()
        {
            Console.WriteLine($"{_character.Name} attacks {_target.Name}!");
            _target.Health -= _character.Strength;
        }
    }

    public class DefendCommand : ICommand
    {
        private readonly Character _character;

        public DefendCommand(Character character)
        {
            _character = character;
        }

        public void Execute()
        {
            Console.WriteLine($"{_character.Name} is defending!");
            _character.SetState(new DefendingState()); // Use the state pattern for defending state
        }
    }

    public class HealCommand : ICommand
    {
        private readonly Character _character;
        private readonly int _healingAmount;

        public HealCommand(Character character, int healingAmount)
        {
            _character = character;
            _healingAmount = healingAmount;
        }

        public void Execute()
        {
            Console.WriteLine($"{_character.Name} heals for {_healingAmount} points!");
            _character.Health += _healingAmount;
        }
    }

    public class MoveCommand : ICommand
    {
        private readonly Character _character;

        public MoveCommand(Character character)
        {
            _character = character;
        }

        public void Execute()
        {
            Console.WriteLine($"{_character.Name} is moving!");
        }
    }
}
