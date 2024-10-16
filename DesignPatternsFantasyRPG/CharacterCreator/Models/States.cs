namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    public interface ICharacterState
    {
        void HandleState(string characterName);
    }

    public class IdleState : ICharacterState
    {
        public void HandleState(string characterName)
        {
            Console.WriteLine($"{characterName} is in idle state.");
        }
    }

    public class ActionState : ICharacterState
    {
        private IActionStrategy _actionStrategy;

        public ActionState(IActionStrategy actionStrategy)
        {
            _actionStrategy = actionStrategy;
        }

        public void HandleState(string characterName)
        {
            Console.WriteLine($"{characterName} is in action mode.");
            _actionStrategy.PerformAction(characterName);
        }
    }

    public class DefendingState : ICharacterState
    {
        public void HandleState(string characterName)
        {
            Console.WriteLine($"{characterName} is defending.");
        }
    }
}
