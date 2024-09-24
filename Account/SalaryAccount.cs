/// <summary>
/// Зарплатный банковский счет.
/// </summary>
public class SalaryAccount : Account
{
    public SalaryAccount()
    {
        Type = "Зарплатный";
    }

    /// <summary>
    /// Рассчитывает проценты для зарплатного счета на основе текущего баланса.
    /// </summary>
    public override void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}