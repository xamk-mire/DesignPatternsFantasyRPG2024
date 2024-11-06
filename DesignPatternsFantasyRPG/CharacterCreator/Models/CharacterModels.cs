using DesignPatternsFantasyRPG.Enums;
using DesignPatternsFantasyRPG.Quests.Models;

namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    public abstract class Character : IObserver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        public CharacterTypeEnum CharacterType { get; set; }

        private ICharacterState _currentState;
        private IActionStrategy _currentAction;

        protected Character()
        {
            // Parameterless constructor for EF Core
        }

        protected Character(string name, int health, int mana, int strength, int agility)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Strength = strength;
            Agility = agility;

            // Default state and action
            _currentState = new IdleState();
            _currentAction = new DefaultAction();
        }

        public abstract void DisplayInfo();


        public void SetAction(IActionStrategy actionStrategy)
        {
            _currentAction = actionStrategy;
            _currentState = new ActionState(_currentAction);
        }

        public void SetState(ICharacterState newState)
        {
            _currentState = newState;
        }

        public void PerformAction()
        {
            _currentState.HandleState(Name);
        }

        public void Update(string questStatus)
        {
            Console.WriteLine($"{Name} received quest update: {questStatus}");
        }
    }
}
