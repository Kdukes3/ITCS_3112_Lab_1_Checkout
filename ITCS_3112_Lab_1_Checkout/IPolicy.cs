namespace ITCS_3112_Lab_1_Checkout;

public interface IPolicy
{
    bool CanCheckout(Item item);
    DateTime NormalizeDueDate(DateTime proposed);
}