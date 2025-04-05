namespace Lesson9
{
    public class Lesson9Task2Tests
    {
        // тестирование конструктора и свойств
        [Fact]
        public void Constructor_ShouldInitializeAccountWithZeroBalance()
        {
            // Arrange & Act
            var account = new BankAccount();

            // Assert
            Assert.Equal(0, account.Balance);
            Assert.NotEqual(Guid.Empty, account.AccountNumber);
        }

        [Fact]
        public void Constructor_ShouldIncrementTotalAccounts()
        {
            // Arrange
            int initialCount = BankAccount.TotalAccounts;

            // Act
            var account1 = new BankAccount();
            var account2 = new BankAccount();

            // Assert
            Assert.Equal(initialCount + 2, BankAccount.TotalAccounts);
        }
        // тестирование метода Deposit
        [Fact]
        public void Deposit_ShouldIncreaseBalance()
        {
            // Arrange
            var account = new BankAccount();
            decimal initialBalance = account.Balance;
            int depositAmount = 100;

            // Act
            account.Deposit(depositAmount);

            // Assert
            Assert.Equal(initialBalance + depositAmount, account.Balance);
        }

        [Fact]
        public void Deposit_WithNegativeAmount_ShouldThrowException()
        {
            // Arrange
            var account = new BankAccount();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Deposit(-50));
        }

        [Fact]
        public void Deposit_WithZeroAmount_ShouldThrowException()
        {
            // Arrange
            var account = new BankAccount();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Deposit(0));
        }
        // тестирование метода Withdraw
        [Fact]
        public void Withdraw_ShouldDecreaseBalance()
        {
            // Arrange
            var account = new BankAccount();
            account.Deposit(200); // Предварительно кладём деньги
            decimal initialBalance = account.Balance;
            decimal withdrawAmount = 100;

            // Act
            account.Withdraw(withdrawAmount);

            // Assert
            Assert.Equal(initialBalance - withdrawAmount, account.Balance);
        }

        [Fact]
        public void Withdraw_WithNegativeAmount_ShouldThrowException()
        {
            // Arrange
            var account = new BankAccount();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-50));
        }

        [Fact]
        public void Withdraw_WithZeroAmount_ShouldThrowException()
        {
            // Arrange
            var account = new BankAccount();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(0));
        }

        [Fact]
        public void Withdraw_WithInsufficientBalance_ShouldThrowException()
        {
            // Arrange
            var account = new BankAccount();
            account.Deposit(50); // Баланс: 50

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(100));
        }
        // тестирование поля _totalAccount
        [Fact]
        public void TotalAccounts_ShouldReflectCreatedAccounts()
        {
            // Arrange
            int initialCount = BankAccount.TotalAccounts;

            // Act
            var account1 = new BankAccount();
            var account2 = new BankAccount();

            // Assert
            Assert.Equal(initialCount + 2, BankAccount.TotalAccounts);
        }
        // интеграционный тест Deposit + Withdraw
        [Fact]
        public void DepositAndWithdraw_ShouldUpdateBalanceCorrectly()
        {
            // Arrange
            var account = new BankAccount();
            account.Deposit(300);
            account.Withdraw(150);

            // Assert
            Assert.Equal(150, account.Balance);
        }
    }
}
