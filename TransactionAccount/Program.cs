using TransactionAccount;

namespace TransacionAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var account = new Account(1000);

            Console.WriteLine($"Saldo atual: {account.Balance}");

            account.Draw(1500);

            Console.WriteLine($"Saldo atual: {account.Balance}");

            account.Deposit(2000);
            account.Draw(1000);

            Console.WriteLine($"Saldo atual: {account.Balance}");
        }
    }
}