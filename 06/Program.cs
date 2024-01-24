internal class Account
{
    private readonly string _name;
    private readonly int _accountNo;
    private double _balance;
    private static int _noOfAccounts;
    private static double _interestRate = 6;
    public Account(string name, double balance)
    {
        _name = name;
        _accountNo = ++_noOfAccounts;
        _balance = balance;
    }
    public static void SetInterestRate(double interestRate)
    {
        _interestRate = interestRate;
        Console.WriteLine($"Interest Rate changed to {_interestRate} %");
    }
    public void CreditInterest()
    {
        double interestPercentage = _interestRate / 100;
        double interestAmount = _balance * interestPercentage;
        _balance += interestAmount;
        Console.WriteLine($"Annual interest is credited of amout: {interestAmount}, now current balance is: {_balance}");
    }
    public void Display()
    {
        Console.WriteLine($"Account Number : {_accountNo}, Name : {_name}, Balance : {_balance}");
    }
    public void CreditAmount(double creditAmount)
    {
        _balance += creditAmount;
        Console.WriteLine($"Credit Amount is {creditAmount}, now current balance is: {_balance}");
    }
    public void WithdrawAmount(double withdrawAmount)
    {
        if (withdrawAmount <= 0)
        {
            Console.WriteLine("Invalid withdraw amount.");
            return;
        }

        if (_balance > 0 && withdrawAmount <= _balance)
        {
            _balance -= withdrawAmount;
            Console.WriteLine($"Withdraw Amount is {withdrawAmount} and Current Balance is : {_balance}, now current balance is: {_balance}");
        }
        else
            Console.WriteLine("Insufficient Balance.");
    }
}
internal abstract class Program
{
    public static void Main(string[] args)
    {
        var account = new Account("Abhishek Kumar", 443128);
        account.Display();
        Account.SetInterestRate(9);
        account.CreditInterest();
        account.CreditAmount(4431);
        account.WithdrawAmount(-28);
        account.WithdrawAmount(72832);
    }
}
