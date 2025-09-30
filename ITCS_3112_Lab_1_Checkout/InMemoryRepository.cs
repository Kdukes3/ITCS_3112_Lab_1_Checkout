namespace ITCS_3112_Lab_1_Checkout;

public class InMemoryRepository : IRepository
{
    //Inventory for all items
    private Dictionary<string, Item> _inventory = new Dictionary<string, Item>();
    List<Item> _items = new List<Item>();

    public void SaveItem(Item item)
    {
        _inventory[item.Id] = item;
        //_items.Add(item);
    }

    public Item GetItem(string itemId)
    {
        return _inventory[itemId];
    }

    public List<Item> AllItems()
    {
        
    }

    public void SaveRecord(CheckoutRecord record)
    {
        throw new NotImplementedException();
    }

    public CheckoutRecord GetActiveRecordFor(string itemId)
    {
        throw new NotImplementedException();
    }

    public List<CheckoutRecord> AllRecords()
    {
        throw new NotImplementedException();
    }
}