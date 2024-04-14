using System;
using System.Collections.Generic;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader peter = new Trader("Peter");
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1001));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1002));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1003));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1004));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1005));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1006));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1007));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1008));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1009));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1010));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1011));
            peter.AddItemToInventory(ItemFactory.CreateGameItem(1012));
            
            AddTraderToList(peter);
            
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}