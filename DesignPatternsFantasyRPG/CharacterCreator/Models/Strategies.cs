namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    public interface IActionStrategy
    {
        void PerformAction(string characterName);
    }

    public class DefaultAction : IActionStrategy
    {
        public void PerformAction(string characterName)
        {
            Console.WriteLine($"{characterName} is looking around curiously");
        }
    }

    public class MeleeAction : IActionStrategy
    {
        public void PerformAction(string characterName)
        {
            Console.WriteLine($"{characterName} is performing melee attack!");
        }
    }

    public class RangedAction : IActionStrategy
    {
        public void PerformAction(string characterName)
        {
            Console.WriteLine($"{characterName} is performing ranged attack!");
        }
    }

    public class MagicAction : IActionStrategy
    {
        public void PerformAction(string characterName)
        {
            Console.WriteLine($"{characterName} is casting a magic spell!");
        }
    }   

    public class HealAction : IActionStrategy
    {
        public void PerformAction(string characterName)
        {
            Console.WriteLine($"{characterName} is performing healing action!");
        }
    }
}
