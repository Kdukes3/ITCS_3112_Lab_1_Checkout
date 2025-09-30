namespace ITCS_3112_Lab_1_Checkout;

public class SystemClock : IClock 
{
    public DateTime Today()
    {
        return DateTime.Now;
    }
}