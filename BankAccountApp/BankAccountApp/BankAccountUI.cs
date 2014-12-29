using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class BankAccountUI : Form
    {
        public BankAccountUI()
        {
            InitializeComponent();
        }

        private Customer aCustomer;
        private void saveButton_Click(object sender, EventArgs e)
        {
            Account anAccount = new Account();
            aCustomer = new Customer();
            anAccount.AccountNo = accountNoEntryTextBox.Text;
            anAccount.OpeningDate = openningDateEntryTextBox.Text;
            aCustomer.Name = nameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;
            aCustomer.CustomerAccount = anAccount;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.Deposit(amount);
                MessageBox.Show("Deposited");
            }
            else
            {
                MessageBox.Show("Create an CustomerAccount First");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.Withdraw(amount);
                MessageBox.Show("Withdrawn");
            }
            else
            {
                MessageBox.Show("Create an CustomerAccount First");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            customerNameDisplayTextBox.Text = aCustomer.Name;
            emailDisplayTextBox.Text = aCustomer.Email;
            accountnoDisplayTextBox.Text = aCustomer.CustomerAccount.AccountNo;
            openingDateDisplayTextBox.Text = aCustomer.CustomerAccount.OpeningDate;
            balanceDisplayTextBox.Text = aCustomer.CustomerAccount.Balance.ToString();
        }
    }
}
