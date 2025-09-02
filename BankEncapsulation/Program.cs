namespace BankEncapsulation
{
    public class Program

    {
    static void Main(string[] args)
    {
        var account = new BankAccount();
        
        Console.WriteLine($"Your account currently has ${account.GetBalance()}. How much would you like to deposit?");
        
        var amountDeposit = double.Parse(Console.ReadLine());

        account.Deposit(amountDeposit);

        Console.WriteLine($"Your account balance is: ${account.GetBalance()}");
        
        //var accountChoice 
        
        //Console.WriteLine("Would you like to make a deposit or withdraw");
        
        Console.WriteLine("How much would you like to withdraw?");
        
        var amountWithdraw = double.Parse(Console.ReadLine());
        
        account.Withdraw(amountWithdraw);
        
        Console.WriteLine($"Your account balance is: ${account.GetBalance()}");
        
        
        //Console.WriteLine("You have deposited {} and now your balance is {balance}");
        //Console.WriteLine("How much would you like to withdraw?");
        //Console.WriteLine("Withdrawl complete, your balance is now: {balance}");



    }
    }
}
