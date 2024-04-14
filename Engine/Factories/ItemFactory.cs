using System.Collections.Generic;
using System.Linq;
using Engine.Actions;
using Engine.Models;
namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            BuildWeapon(1001, "Rusty Sword", 100, 15, 2);
            BuildWeapon(1002, "Steel Sword", 200, 25, 3);
            BuildWeapon(1003, "Bow", 200, 25, 3);
            BuildWeapon(1004, "Staff", 200, 25, 3);
            BuildWeapon(1005, "Spear", 200, 25, 3);
            BuildWeapon(1006, "Cronus' Scythe", 1000, 50, 3);
            BuildWeapon(1007, "Apollo's Bow", 1000, 50, 3);
            BuildWeapon(1008, "Holy Grimoire", 1000, 60, 3);
            BuildWeapon(1009, "Pulse Bow", 2500, 100, 3);
            BuildWeapon(1010, "Elder Wand", 2500, 100, 3);
            BuildWeapon(1011, "Enchanted Sword", 5000, 250, 3);
            BuildWeapon(1012, "Legendary Murasama", 10000, 600, 3);
            BuildWeapon(1501, "Wolf Fangs", 0, 0, 75);
            BuildWeapon(1502, "Demon Claws", 0, 0, 100);
            BuildWeapon(1503, "Demon King Sword", 0, 0, 200);
            BuildHealingItem(2001, "Health Potion", 75, 200);
            BuildMiscellaneousItem(3001, "Lemongrass", 50);
            BuildMiscellaneousItem(3002, "Wolf Blood", 100);
            BuildMiscellaneousItem(3003, "Holy Water", 150);
            BuildMiscellaneousItem(9001, "Wolf Claw", 50);
            BuildMiscellaneousItem(9002, "Wolf Fang", 100);
            BuildMiscellaneousItem(9003, "Wolf Fur", 250);
            BuildMiscellaneousItem(9004, "Demon Horn", 250);
            BuildMiscellaneousItem(9005, "Demon Heart", 500);
            BuildMiscellaneousItem(9006, "Demon King Heart", 1000);
            BuildMiscellaneousItem(9007, "Demon King Head", 1000);
        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }
        private static void BuildMiscellaneousItem(int id, string name, int price)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name, price));
        }
        private static void BuildWeapon(int id, string name, int price,
                                        int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name, price, true);
            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);
            _standardGameItems.Add(weapon);
        }
        private static void BuildHealingItem(int id, string name, int price, int hitPointsToHeal)
        {
            GameItem item = new GameItem(GameItem.ItemCategory.Consumable, id, name, price);
            item.Action = new Heal(item, hitPointsToHeal);
            _standardGameItems.Add(item);
        }
        public static string ItemName(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID)?.Name ?? "";
        }
    }
}