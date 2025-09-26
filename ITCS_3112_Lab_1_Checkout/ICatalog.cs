namespace ITCS_3112_Lab_1_Checkout;

public interface ICatalog
{
    List<Item> ListAvailable();
    List<Item> ListUnavailable();
    Item FindById(string itemId);
    List<Item> SearchBy(int criteria, string query);
}