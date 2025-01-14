using Bank;
Console.Clear();

BankAccount phil = new BankAccount("123456", (decimal)500.00);
Console.WriteLine($"Account Number: {phil.AccountNumber}");
Console.WriteLine($"Current Balance: {phil.Balance}\n");

phil.Deposit((decimal)100.00);

phil.Deposit((decimal)-100.00);

phil.Withdraw((decimal)200.00);

phil.Withdraw((decimal)1000.00);

phil.Withdraw((decimal)-1000.00);



