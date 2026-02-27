using System.Collections.Generic;

public class Equipment : IEquipment
{
    List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
    }
}