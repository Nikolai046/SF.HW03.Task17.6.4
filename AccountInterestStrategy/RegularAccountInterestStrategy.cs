/// <summary>
/// Стратегия расчета процентов для обычного счета.
/// </summary>
public class RegularAccountInterestStrategy : IInterestStrategy
{
    public double CalculateInterest(double balance)
    {
        return balance < 1000 ? balance * 0.2 : 0;
    }
}