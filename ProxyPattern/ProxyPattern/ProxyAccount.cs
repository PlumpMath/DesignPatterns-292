using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPattern
{
    public class ProxyAccount : Account
    {
        private double withdrawLimit;
        private Account account;
        private string name;
        public ProxyAccount(double withdrawLimit, string name)
        {
            this.withdrawLimit = withdrawLimit;
            this.account = new RealAccount();
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void deposit(double amount)
        {
            account.deposit(amount);
        }

        public double withdraw(double amount)
        {
            if (amount <= account.getBalance())
            {
                if (amount <= withdrawLimit)
                {
                    return account.withdraw(amount);
                }
                MessageBox.Show("This withdraw is over the withdraw limit.");
                return 0;
            }
            MessageBox.Show("This withdraw would overdraw the account");
            return 0;
        }

        public double getBalance()
        {
            return account.getBalance();
        }

        public override string ToString()
        {
            return name;
        }
    }
}
