using System.Collections.Generic;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {
            // Declare the items need to complete the quest, and its reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            
            itemsToComplete.Add(new ItemQuantity(9002, 10));
            rewardItems.Add(new ItemQuantity(1001, 1));
            rewardItems.Add(new ItemQuantity(9003, 5));
            // Create the quest
            _quests.Add(new Quest(1,
                                  "Obtain 10 Wolf Claws",
                                  "Unpacking the Pack",
                                  itemsToComplete,
                                  250, 500,
                                  rewardItems));

            List<ItemQuantity> itemsToComplete2 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems2 = new List<ItemQuantity>();

            itemsToComplete2.Add(new ItemQuantity(9004, 5));
            
            _quests.Add(new Quest(2,
                                  "Obtain 5 Demon Hearts",
                                  "Banishing the Tainted",
                                   itemsToComplete2,
                                   500, 1000,
                                   rewardItems2));

            List<ItemQuantity> itemsToComplete3 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems3 = new List<ItemQuantity>();

            itemsToComplete3.Add(new ItemQuantity(9006, 1));

            _quests.Add(new Quest(3,
                                  "Obtain 1 Demon King Heart",
                                  "Free Yggdrasil",
                                   itemsToComplete3,
                                   10000, 1000000,
                                   rewardItems3));

        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}