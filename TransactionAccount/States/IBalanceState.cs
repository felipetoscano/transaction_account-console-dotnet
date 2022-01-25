namespace TransactionAccount.States
{
    public interface IBalanceState
    {
        public void Deposit(double value, Account account);
        public void Draw(double value, Account account);
    }
}
