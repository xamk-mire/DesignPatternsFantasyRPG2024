namespace DesignPatternsFantasyRPG.CharacterBehavior.Models
{
    public interface IActionStrategy
    {
        void PerformAction();
    }

    public class MeleeAction : IActionStrategy
    {
        public void PerformAction()
        {
            Console.WriteLine("Performing melee attack!");
        }
    }

    public class RangedAction : IActionStrategy
    {
        public void PerformAction()
        {
            Console.WriteLine("Performing ranged attack!");
        }
    }

    public class MagicAction : IActionStrategy
    {
        public void PerformAction()
        {
            Console.WriteLine("Casting a magic spell!");
        }
    }

    public class HealAction : IActionStrategy
    {
        public void PerformAction()
        {
            Console.WriteLine("Performing healing action!");
        }
    }
}
