namespace TransactionAccount.States
{
    public class PositiveBalance : IBalanceState
    {
        public void Deposit(double value, Account account)
        {
            account.Balance += value * 0.98;
        }

        public void Draw(double value, Account account)
        {
            account.Balance -= value;

            if (account.Balance < 0)
            {
                account.State = new NegativeBalance();
            }
        }
    }
}
