using System.Collections.Generic;
using PlayerSingleton;

namespace PlayerSingleton
{
    public class Equipment : IEquipment
    {
        List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }
    }
}