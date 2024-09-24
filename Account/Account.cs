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
    /// Абстрактный метод для расчета процентов.
    /// </summary>
    public abstract void CalculateInterest();
}