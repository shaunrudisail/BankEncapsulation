namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0.00;
    
    public double Deposit(double amount)
    {
        _balance += amount;
        return amount;
    }

    public double GetBalance()
    {
        return _balance;
    }
}