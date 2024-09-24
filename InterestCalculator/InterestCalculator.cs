/// <summary>
/// Калькулятор процентной ставки.
/// </summary>
public class InterestCalculator : IInterestCalculator
{
    /// <summary>
    /// Рассчитывает проценты для указанного счета.
    /// </summary>
    /// <param name="account">Счет, для которого нужно рассчитать проценты.</param>
    public void CalculateInterest(Account account)
    {
        account.CalculateInterest();
    }
}