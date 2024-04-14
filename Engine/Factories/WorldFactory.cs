using Engine.Models;
namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            
            newWorld.AddLocation(1, 1, "FrostBite Peaks",
                "Where the wolf sleeps.",
                "FrostBitePeaks.png");
            
            newWorld.LocationAt(1, 1).AddMonster(1, 100);
           
            newWorld.AddLocation(-1, -1, "Silvermoon Grave",
                "Where the Common Demon Soldier indulges the fear from the innocent people of Yggdrasil.",
                "SilverMooonGrave.png");

            newWorld.LocationAt(-1, -1).AddMonster(2, 100);
            
            newWorld.AddLocation(0, -1, "Ironhold Citadel",
                "Where Slyvanwood The Healer resides",
                "IronholdCitadel.png");
            
            newWorld.AddLocation(-1, 0, "Glimmering Shores",
                "Eldoria the Side Quest giver protects her Kingdom.",
                "GlimmeringShores.jpg");

            newWorld.LocationAt(-1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));

            newWorld.AddLocation(0, 0, "Moon Shadow Keep",
                "Where Garen is located.",
                "MoonShadowKeep.png");

            newWorld.LocationAt(0, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));

            newWorld.AddLocation(1, -1, "Mysthaven",
                "This is your Headquarters.",
                "Headquarters.jpg");
           
            newWorld.AddLocation(1, 0, "Whispering Woods",
                "This is where Valoria the Elf enjoys being with Nature and gives quests.",
                "WhisperingWoods.png");

            newWorld.LocationAt(1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 1, "Demon Kingdom Gate",
                "This is where Peter the Merchant trades.",
                "DemonKingdomGate.jpg");

           newWorld.LocationAt(0, 1).TraderHere = TraderFactory.GetTraderByName("Peter");

           
            newWorld.AddLocation(-1, 1, "Demon Castle",
                "Where the ominous Demon King Sauron plans his devious attacks.",
                "DemonCastle.png");
           
            newWorld.LocationAt(-1, 1).AddMonster(3, 100);

            return newWorld;
        }
    }
}