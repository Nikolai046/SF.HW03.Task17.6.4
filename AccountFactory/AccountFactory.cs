/// <summary>
/// Конкретная реализация фабрики счетов.
/// </summary>
public class AccountFactory : IAccountFactory
{
    public Account CreateAccount(string accountType, double initialBalance)
    {
        switch (accountType.ToLower())
        {
            case "regular":
                return new RegularAccount { Balance = initialBalance };

            case "salary":
                return new SalaryAccount { Balance = initialBalance };

            default:
                throw new ArgumentException("Unknown account type", nameof(accountType));
        }
    }
}