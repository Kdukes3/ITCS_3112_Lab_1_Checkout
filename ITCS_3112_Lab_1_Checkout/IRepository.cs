namespace ITCS_3112_Lab_1_Checkout;

public interface IRepository
{
    void SaveItem(Item item);
    Item GetItem(string itemId);
    List<Item> AllItems();
    void SaveRecord(CheckoutRecord record);
    CheckoutRecord GetActiveRecordFor(string itemId);
    List<CheckoutRecord> AllRecords();
}