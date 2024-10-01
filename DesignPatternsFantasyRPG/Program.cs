using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.CharacterCreator;
using DesignPatternsFantasyRPG.GameWorldCreator.Models;
using DesignPatternsFantasyRPG.GameWorldCreator;

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

            Character warrior = warriorFactory.CreateCharacter("Conan");
            Character mage = mageFactory.CreateCharacter("Merlin");
            Character archer = archerFactory.CreateCharacter("Legolas");

            // Display character information
            // TODO: Could add a list of PlayerCharacters to GameWorld, and loop the list instead
            //       e.g. NPC implementation
            warrior.DisplayInfo();
            mage.DisplayInfo();
            archer.DisplayInfo();

            // Add NPCs to the game world
            // TODO: Extend NPC class -> Jobs, Skills, Inventory, Roles
            gameWorld.AddNPC(new NPC("Villager"));
            gameWorld.AddNPC(new NPC("Merchant"));

            foreach (var npc in gameWorld.NPCs)
            {
                npc.DisplayInfo();
            }

            // Print the generated map 
            GameWorldGenerator.PrintMap(gameWorld.WorldMap);
        }
    }
}
