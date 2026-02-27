using System.Collections.Generic;

namespace PlayerDI
{
    public interface IEquipment
    {
        void AddItem(Item item);
        IReadOnlyList<Item> GetItems();
    }
}