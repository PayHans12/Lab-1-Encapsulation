namespace Bank;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;
    public string AccountNumber { get; }
    public decimal Balance { get; }

    public BankAccount(string accountNumber, decimal initialbalance)
    {
        this.accountNumber = AccountNumber = accountNumber;
        if (initialbalance < 0)
        {
            initialbalance = 0;
        }
        balance = Balance = initialbalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Depositing: ${amount}");
            Console.WriteLine($"New Balance: ${balance}\n");
        }
        else
        {
            Console.WriteLine("Error: that is an invalid amount.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawing: ${amount}");
            Console.WriteLine($"New Balance: ${balance}\n");
        }
        else
        {
            if (amount > balance)
            {
                Console.WriteLine($"Withdrawing: ${amount}");
                Console.WriteLine("Error: Insuficient Funds\n");
            }
            else
            {
                Console.WriteLine($"Withdrawing: ${amount}");
                Console.WriteLine("Invalid amount\n");
            }
        }
    }

}