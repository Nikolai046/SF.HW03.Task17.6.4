/// <summary>
/// Фабрика для создания счетов.
/// </summary>
public interface IAccountFactory
{
    Account CreateAccount(string accountType, double initialBalance);
}