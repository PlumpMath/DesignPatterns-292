using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPattern
{
    public partial class Form1 : Form
    {
        private List<Account> account = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            ProxyAccount newAccount = new ProxyAccount(Double.Parse(tbLimit.Text), tbName.Text);
            account.Add(newAccount);
            cbAccounts.Items.Add(newAccount);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            ProxyAccount temp = (ProxyAccount)cbAccounts.SelectedItem;
            temp.deposit(Double.Parse(tbAmount.Text));
            displayBalance(temp);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            ProxyAccount temp = (ProxyAccount)cbAccounts.SelectedItem;
            temp.withdraw(Double.Parse(tbAmount.Text));
            displayBalance(temp);
        }

        private void displayBalance(ProxyAccount temp)
        {
            lblAccountInfo.Text = temp.ToString() + " has a total of $" + temp.getBalance();
        }
    }
}
