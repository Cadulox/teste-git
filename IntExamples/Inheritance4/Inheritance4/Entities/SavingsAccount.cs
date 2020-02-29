namespace Inheritance4.Entities
{
    sealed class SavingsAccount : Account
        // A classe selada evita que seja herdada em outra subclasse
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        // O método selado evita que não seja sobreposto em outra subclasse
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}