/// <summary>
/// Абстрактный базовый класс для всех типов банковских счетов.
/// </summary>
public abstract class Account
{
    /// <summary>
    /// Тип учетной записи.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Баланс учетной записи
    /// </summary>
    public double Balance { get; set; }

    /// <summary>
    /// Процентная ставка
    /// </summary>
    public double Interest { get; protected set; }

    /// <summary>
    /// Метод для расчета процентов.
    /// </summary>
    public void CalculateInterest(IInterestStrategy strategy)
    {
        Interest = strategy.CalculateInterest(Balance);
    }
}