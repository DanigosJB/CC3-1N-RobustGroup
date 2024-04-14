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
        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}