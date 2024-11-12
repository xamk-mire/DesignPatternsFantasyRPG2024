﻿using DesignPatternsFantasyRPG.Quests.Models;

namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    public abstract class Character : IObserver
    {
        // Hacked unique character ID -> would be autogenerated when using database
        // Prevents duplicate characters
        private static int nextId = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        private ICharacterState _currentState;
        private IActionStrategy _currentAction;

        protected Character(string name, int health, int mana, int strength, int agility)
        {
            Id = nextId++;
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
            // Check if the action can be changed
            if (_currentState.CanUpdateAction(Name, actionStrategy))
            {
                _currentAction = actionStrategy;
            }
        }

        public void SetState(ICharacterState newState)
        {
            _currentState = newState;
        }

        public void PerformAction()
        {
            _currentState.HandleState(Name, _currentAction);
        }

        public void Update(string questStatus)
        {
            Console.WriteLine($"{Name} received quest update: {questStatus}");
        }
    }
}
