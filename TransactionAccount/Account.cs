using TransactionAccount.States;

namespace TransactionAccount
{
    public class Account
    {
        public double Balance { get; set; }
        public IBalanceState State { get; set; }

        public Account(double balance)
        {
            Balance = balance;
            State = balance > 0 ? State = new PositiveBalance() : new NegativeBalance();
        }

        public void Deposit(double value)
        {
            State.Deposit(value, this);
        }

        public void Draw(double value)
        {
            State.Draw(value, this);
        }
    }
}
