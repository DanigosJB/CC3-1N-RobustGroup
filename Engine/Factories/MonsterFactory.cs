using System;
using Engine.Models;
namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster wolf =
                        new Monster("Wolf", "Wolf.png", 250, 250, 25, 50, 50, 10);
                    AddLootItem(wolf, 9002, 30);
                    AddLootItem(wolf, 9001, 70);

                    return wolf;

                case 2:
                    Monster demonsoldier =
                        new Monster("Demon Soldier", "DemonSoldier.png", 500, 500, 50, 100, 100, 100);
                    AddLootItem(demonsoldier, 9005, 15);
                    AddLootItem(demonsoldier, 9005, 85);

                    return demonsoldier;

                case 3:
                    Monster DemonKing =
                        new Monster("Demon King", "DemonKing.png", 1000, 1000, 70, 150, 1000, 1000);
                    AddLootItem(DemonKing, 9006, 50);
                    AddLootItem(DemonKing, 9007, 50);

                    return DemonKing;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}