using System;

namespace ProxyPattern
{
    public class RealAccount : Account
    {
        private double balance = 0;
        public void deposit(double amount)
        {
            balance += amount;
        }

        public double getBalance()
        {
            return balance;
        }

        public double withdraw(double amount)
        {
            balance -= amount;
            return amount;
        }
    }
}