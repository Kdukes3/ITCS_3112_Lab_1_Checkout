namespace ITCS_3112_Lab_1_Checkout;

public class Borrower
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Borrower(string name, string email)
    {
        Name = name;
        Email = email;
    }
}