namespace TransactionAccount.States
{
    public class NegativeBalance : IBalanceState
    {
        public void Deposit(double value, Account account)
        {
            account.Balance += value * 0.95;

            if (account.Balance > 0)
            {
                account.State = new PositiveBalance();
            }
        }

        public void Draw(double value, Account account)
        {
            throw new Exception("Conta não possui saldo");
        }
    }
}
