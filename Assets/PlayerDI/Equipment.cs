using System.Collections.Generic;

namespace PlayerDI
{
    public class Equipment : IEquipment
    {
        private readonly List<Item> _items = new();

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public IReadOnlyList<Item> GetItems() => _items;
    }
}