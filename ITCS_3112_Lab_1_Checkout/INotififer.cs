namespace ITCS_3112_Lab_1_Checkout;

public interface INotififer
{
    void DueSoon(Borrower borrower, CheckoutRecord record);
    void Overdue(Borrower borrower, CheckoutRecord record);
}