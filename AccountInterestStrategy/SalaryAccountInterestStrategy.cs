/// <summary>
/// Стратегия расчета процентов для зарплатного счета.
/// </summary>
public class SalaryAccountInterestStrategy : IInterestStrategy
{
    public double CalculateInterest(double balance)
    {
        return balance * 0.5;
    }
}