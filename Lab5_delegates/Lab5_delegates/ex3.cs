using Lab5_delegates;

BankAccount bankAccount = new BankAccount();
bankAccount.Overdraft += OverdraftFunction;
bankAccount.BalanceChanged += BalanceChanged;

bankAccount.Deposit(40000);
bankAccount.Withdraw(35000);
bankAccount.Withdraw(7000);
bankAccount.Withdraw(bankAccount.GetBalance());
bankAccount.Deposit(decimal.MaxValue);

void OverdraftFunction(decimal amount)
{
    Console.WriteLine($"Предлагаем клиенту рассрочку на сумму: {amount}");
}
void BalanceChanged(decimal newBalance)
{
    Console.WriteLine($"Подозрительное движение денежных средств, новый баланс {newBalance}");

}