/// <summary>
/// Интерфейс для калькулятора процентов.
/// </summary>
public interface IInterestCalculator
{
    /// <summary>
    /// Рассчитывает проценты для указанного счета.
    /// </summary>
    /// <param name="account">Счет, для которого нужно рассчитать проценты.</param>
    void CalculateInterest(Account account);
}