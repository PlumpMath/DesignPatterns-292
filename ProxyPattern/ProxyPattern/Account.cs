using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface Account
    {
        double getBalance();
        double withdraw(double amount);
        void deposit(double amount);
    }
}
