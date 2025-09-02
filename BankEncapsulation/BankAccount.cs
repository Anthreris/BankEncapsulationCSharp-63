namespace BankEncapsulation;

public class BankAccount
{
    
    private double _balance = 0; //Hidden, but available via public methods below
    
    //Encapsulation
    
    public void Deposit(double amount)
    {
        _balance += amount;
    }
    
    public double GetBalance()
    {
        return _balance;
    }

    public void Withdraw(double amount)
    {
        _balance -= amount;
    }

    // public void Choice(char choice)
    // {
    //     Console.ReadKey();
    //     if
    //     {
    //         Console.ReadKey() == 'D';
    //     }
    //}
}