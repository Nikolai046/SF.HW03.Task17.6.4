/// <summary>
/// Интерфейс для стратегии расчета процентов.
/// </summary>
public interface IInterestStrategy
{
    /// <summary>
    /// Рассчитывает проценты для указанного баланса.
    /// </summary>
    /// <param name="balance">Баланс счета.</param>
    /// <returns>Рассчитанные проценты.</returns>
    double CalculateInterest(double balance);
}