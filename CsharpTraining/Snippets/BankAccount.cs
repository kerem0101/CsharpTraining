

namespace CsharpTraining.Snippets
{
    internal class BankAccount
    {
        private decimal balance = 0;

        public decimal Balance
        {
            get => balance;
        }

        public BankAccount(decimal balance)
        {
            this.balance = balance;
        }
        
        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Deposit amount should be positive number!");
            }
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount should be positive number!");
            }
            if (amount > balance) 
            {
                throw new InvalidOperationException("Insufficient funds!"); 

            }
            balance -= amount;
        }

    }
}
