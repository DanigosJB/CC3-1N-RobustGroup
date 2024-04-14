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
                        new Monster("Wolf", "Wolf.png", 4, 100, 5, 1);
                    wolf.CurrentWeapon = ItemFactory.CreateGameItem(1501);
                    AddLootItem(wolf, 9001, 25);
                    AddLootItem(wolf, 9002, 75);
                    return wolf;
                
                case 2:
                    Monster demonsoldier =
                        new Monster("Demon Soldier", "DemonSoldier.png", 5, 300, 5, 1);
                    demonsoldier.CurrentWeapon = ItemFactory.CreateGameItem(1502);
                    AddLootItem(demonsoldier, 9003, 25);
                    AddLootItem(demonsoldier, 9004, 75);
                    return demonsoldier;
                
                case 3:
                    Monster sauron =
                        new Monster("Demon King Sauron", "DemonKing.png", 10, 1000, 10, 3);
                    sauron.CurrentWeapon = ItemFactory.CreateGameItem(1503);
                    AddLootItem(sauron, 9005, 25);
                    AddLootItem(sauron, 9006, 75);
                    return sauron;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}