using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1000, "Rusty Sword", 50, 10, 20));
            _standardGameItems.Add(new Weapon(1001, "Steel Sword", 200, 20, 50));
            _standardGameItems.Add(new Weapon(1002, "Bow", 200, 50, 70));
            _standardGameItems.Add(new Weapon(1003, "Staff", 200, 50, 100));
            _standardGameItems.Add(new Weapon(1004, "Spear", 250, 50, 100));
            _standardGameItems.Add(new Weapon(1005, "Cronus' Scythe", 1500, 150, 225));
            _standardGameItems.Add(new Weapon(1006, "Apollo's Bow", 1000, 125, 180));
            _standardGameItems.Add(new Weapon(1007, "Holy Grimoire", 1000, 100, 170));
            _standardGameItems.Add(new Weapon(1008, "Pulse Bow", 5000, 185, 250));
            _standardGameItems.Add(new Weapon(1009, "Elder Wand", 5000, 180, 250));
            _standardGameItems.Add(new Weapon(1010, "Enchanted Sword", 5000, 200, 300));
            _standardGameItems.Add(new Weapon(1011, "Legendary Murasama", 10000, 500, 1000));
            _standardGameItems.Add(new GameItem(9001, "Wolf Fang",50));
            _standardGameItems.Add(new GameItem(9002, "Wolf Claw",100));
            _standardGameItems.Add(new GameItem(9003, "Wolf Fur",200));
            _standardGameItems.Add(new GameItem(9004, "Demon Heart",500));
            _standardGameItems.Add(new GameItem(9005, "Demon Horn",250));
            _standardGameItems.Add(new GameItem(9006, "Demon King Heart",1000));
            _standardGameItems.Add(new GameItem(9007, "Demon King Head",1000));
        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }
                return standardItem.Clone();
            }
            return null;
        }
    }
}