public class Program
{
    public static void Main(string[] args)
    {
        IInterestCalculator calculator = new InterestCalculator();

        Account regularAccount = new RegularAccount { Balance = 500 };
        Account regularAccountHighBalance = new RegularAccount { Balance = 2000 };
        Account salaryAccount = new SalaryAccount { Balance = 1000 };

        calculator.CalculateInterest(regularAccount);
        calculator.CalculateInterest(regularAccountHighBalance);
        calculator.CalculateInterest(salaryAccount);

        Console.WriteLine($"Обычный счет (баланс 500): Проценты = {regularAccount.Interest}");
        Console.WriteLine($"Обычный счет (баланс 2000): Проценты = {regularAccountHighBalance.Interest}");
        Console.WriteLine($"Зарплатный счет (баланс 1000): Проценты = {salaryAccount.Interest}");
    }
}