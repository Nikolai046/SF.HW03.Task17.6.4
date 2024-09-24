/// <summary>
/// Обычный банковский счет.
/// </summary>
public class RegularAccount : Account
{
    public RegularAccount()
    {
        Type = "Обычный";
    }

    /// <summary>
    /// Рассчитывает проценты для обычного счета на основе текущего баланса.
    /// </summary>
    public override void CalculateInterest()
    {
        Interest = Balance * (Balance < 1000 ? 0.2 : 0);
    }
}