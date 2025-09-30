namespace ITCS_3112_Lab_1_Checkout;

public class Item
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Condition { get; set; }
    public ItemStatus Status { get; set; }

public Item(string id, string name, string category, string condition, ItemStatus status)
    {
    Id = id;
    Name = name;
    Category = category;
    Condition = condition;
    Status = status;
    }
}