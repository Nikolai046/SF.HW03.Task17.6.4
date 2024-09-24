public class Program
{
    public static void Main(string[] args)
    {
        IAccountFactory accountFactory = new AccountFactory();
        IInterestStrategy regularStrategy = new RegularAccountInterestStrategy();
        IInterestStrategy salaryStrategy = new SalaryAccountInterestStrategy();

        var regularAccount = accountFactory.CreateAccount("regular", 500);
        var regularAccountHighBalance = accountFactory.CreateAccount("regular", 2000);
        var salaryAccount = accountFactory.CreateAccount("salary", 1000);

        regularAccount.CalculateInterest(regularStrategy);
        regularAccountHighBalance.CalculateInterest(regularStrategy);
        salaryAccount.CalculateInterest(salaryStrategy);

        Console.WriteLine($"Обычный счет (баланс 500): Проценты = {regularAccount.Interest}");
        Console.WriteLine($"Обычный счет (баланс 2000): Проценты = {regularAccountHighBalance.Interest}");
        Console.WriteLine($"Зарплатный счет (баланс 1000): Проценты = {salaryAccount.Interest}");
    }
}