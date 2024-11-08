using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.CharacterCreator;
using DesignPatternsFantasyRPG.GameWorldCreator.Models;
using DesignPatternsFantasyRPG.GameWorldCreator;
using DesignPatternsFantasyRPG.ItemCreator;
using DesignPatternsFantasyRPG.ItemCreator.Models;
using DesignPatternsFantasyRPG.Quests;

namespace DesignPatternsFantasyRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the game world instace
            var gameWorld = GameWorld.Instance;

            // Define biomes
            var biomes = new List<Biome>
            {
                new Biome("Lake", 0, 10),
                new Biome("Desert", 10, 25),
                new Biome("Forest", 25, 100),
                new Biome("Plains", 100, 150),
                new Biome("Mountain", 150, 200)
            };

            // Generate the world map
            gameWorld.InitializeWorld(10, 10, biomes);

            // Create characters using the factory pattern
            CharacterFactory warriorFactory = new WarriorFactory();
            CharacterFactory mageFactory = new MageFactory();
            CharacterFactory archerFactory = new ArcherFactory();

            // Display character information
            gameWorld.AddCharacter(warriorFactory.CreateCharacter("Conan"));
            gameWorld.AddCharacter(mageFactory.CreateCharacter("Merlin"));
            gameWorld.AddCharacter(archerFactory.CreateCharacter("Legolas"));

            // Add NPCs to the game world
            // TODO: Extend NPC class -> Jobs, Skills, Inventory, Roles
            NpcFactory npcFactory = new NpcFactory();

            gameWorld.AddCharacter(npcFactory.CreateCharacter("Villager"));
            gameWorld.AddCharacter(npcFactory.CreateCharacter("Villager"));

            foreach (var character in gameWorld.WorldCharacters)
            {
                character.DisplayInfo();
            }

            // Item creation examples
            /*
            ItemFacotry commonItemFactory = new CommonItemFactory();

            Weapon commonWeapon = commonItemFactory.CreateWeapon();

            commonWeapon.DisplayInfo();

            ItemFacotry legendaryItemFactory = new LegendaryItemFactory();

            Weapon legendaryWeapon = legendaryItemFactory.CreateWeapon();

            legendaryWeapon.DisplayInfo();
            */

            // Get conan the warrior
            Character conan = gameWorld.WorldCharacters.First(character => character.Name == "Conan");

            // Character actions
            /*
            conan.PerformAction();

            // Set conan state to action
            conan.SetState(new ActionState(new AttackAction()));

            // Perform an action using the default melee attack
            conan.PerformAction();

            // Set conant into defending state
            conan.SetState(new DefendingState());
            conan.PerformAction();
            */

            EnemyManager enemyManager = new EnemyManager();

            Enemy slime = enemyManager.SpawnEnemy("Slime", 1);
            slime.DisplayInfo();

            Enemy goblin = enemyManager.SpawnEnemy("Goblin", 2);
            goblin.DisplayInfo();

            Enemy dragon = enemyManager.SpawnEnemy("Dragon", 5);
            dragon.DisplayInfo();
            dragon.PerformAction();
            dragon.SetAction(new MovementAction());
            dragon.PerformAction();


            QuestManager questManager = new QuestManager();

            QuestManager adventureQuest = new QuestManager();
            QuestManager collectFlowersQuest = new QuestManager();


            questManager.CreateNewQuest("Adventure quest", new List<IObserver> { conan });

            var quests = questManager.GetQuests();

            foreach (var quest in quests)
            {
                quest.UpdateQuestStatus("New quest status");
                quest.QuestCompleted();
            }


            /*

            questManager.RegisterObserver(conan);

            // Quest started
            questManager.UpdateQuestStatus("Quest started: Retrieve the lost artifact");

            // Quest completed
            questManager.UpdateQuestStatus("Quest completed: Artifact retrieved!");

            // Print the generated map 
            GameWorldGenerator.PrintMap(gameWorld.WorldMap);
        }
    }
}
