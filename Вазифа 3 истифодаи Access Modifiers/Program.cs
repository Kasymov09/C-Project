BankAccount account = new BankAccount();
account.Deposit(1000);
account.Deposit(500);
Console.WriteLine(account.GetBalance());
public class BankAccount
{
    private int Balance;
    public int Deposit(int value)
    {
        return Balance+=value;
    }
    public int GetBalance()
    {
        return Balance;
    }
}
