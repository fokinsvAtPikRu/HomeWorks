using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public class BankAccount
    {
        private decimal _balance;
        private static int _totalAccounts;

        public Guid AccountNumber {  get; }
        public decimal Balance => _balance; 
        public static int TotalAccounts => _totalAccounts;
        static BankAccount()
        {
            _totalAccounts = 0;
        }
        public BankAccount()
        {
            AccountNumber = Guid.NewGuid();
            _totalAccounts++;
        }
        public void Deposit(int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма снятия должна быть положительной");
            _balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма зачисления должна быть положительной");
            if (_balance < amount)
                throw new InvalidOperationException("Недостаточно денег на балансе");
            _balance -= amount;
        }        
    }
}
