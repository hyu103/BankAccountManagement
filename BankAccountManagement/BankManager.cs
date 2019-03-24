using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManagement
{
    public partial class BankManager : Form
    {

        public BankManager()
        {
            InitializeComponent();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            if (tbFirstName.TextLength == 0 || tbLastName.TextLength == 0)
            {
                MessageBox.Show("Enter First name and Last name of the customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CustomerAccountManagerDAO customerDAO = new CustomerAccountManagerDAO();
            CustomerAccountManager customer = customerDAO.CreateCustomer(tbFirstName.Text, tbLastName.Text);
            customer.BalanceChanged += customer_BalanceChanged;
            lbBankAccounts.Items.Add(customer);
            tbFirstName.Clear();
            tbLastName.Clear();
            loadSummary();
        }
        private void BankManager_Load(object sender, EventArgs e)
        {
            CustomerAccountManagerDAO customerDAO = new CustomerAccountManagerDAO();
            List<CustomerAccountManager> customerList = customerDAO.LoadAllCustomers();
            
            foreach (CustomerAccountManager customer in customerList)
            {
                lbBankAccounts.Items.Add(customer);
                customer.BalanceChanged += customer_BalanceChanged;
            }
            loadSummary();
        }

        void customer_BalanceChanged(object sender, EventArgs e)
        {
            CustomerAccountManager customer = (CustomerAccountManager)sender;
            int index = lbBankAccounts.SelectedIndex;
            if (index >= 0)
            {
                lbBankAccounts.Items[index] = customer;
            }

            if (customer.chequingBalance == null)
            {
                tbChequingBalance.Text = "N/A";
            }
            else
            {
                tbChequingBalance.Text = string.Format("{0:C2}", customer.chequingBalance);
            }
            if (customer.savingsBalance == null)
            {
                tbSavingsBalance.Text = "N/A";
            }
            else
            {
                tbSavingsBalance.Text = string.Format("{0:C2}", customer.savingsBalance);
            }

            CustomerAccountManagerDAO customerDAO = new CustomerAccountManagerDAO();
            customerDAO.SaveCustomer(customer);
            loadSummary();
        }

        private void loadSummary()
        {
            CustomerAccountManagerDAO customerDAO = new CustomerAccountManagerDAO();
            decimal? totalBalance = customerDAO.TotalOfBalances();
            int numberOfCustomer = customerDAO.NumberOfCustomers();
            lblSummaryCustomer.Text = string.Format("There are {0} customer(s).", numberOfCustomer);
            lblSummaryBalance.Text = string.Format("The total of all account balances is {0:C2}", totalBalance);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            CustomerAccountManager customer = (CustomerAccountManager)lbBankAccounts.SelectedItem;
            if (customer == null)
            {
                return;
            }
            decimal AmountDec;
            decimal.TryParse(tbAmount.Text, out AmountDec);
            
            if (rbChequing.Checked)
            {
                customer.DepositChequing(AmountDec);
            }
            if (rbSavings.Checked)
            {
                customer.DepositSavings(AmountDec);
            }
            tbAmount.Clear();
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            decimal AmountDec;

            if (tbAmount.Text != "" && decimal.TryParse(tbAmount.Text, out AmountDec) && AmountDec > 0)
            {
                btnDeposit.Enabled = true;
                btnWithdraw.Enabled = true;
            }
            else
            {
                btnDeposit.Enabled = false;
                btnWithdraw.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbBankAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerAccountManager customer = (CustomerAccountManager)lbBankAccounts.SelectedItem;
            if (customer != null)
            {
                if (customer.chequingBalance == null)
                {
                    tbChequingBalance.Text = "N/A";
                }
                else
                {
                    tbChequingBalance.Text = string.Format("{0:C2}", customer.chequingBalance);
                }
                if (customer.savingsBalance == null)
                {
                    tbSavingsBalance.Text = "N/A";
                }
                else
                {
                    tbSavingsBalance.Text = string.Format("{0:C2}", customer.savingsBalance);
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            CustomerAccountManager customer = (CustomerAccountManager)lbBankAccounts.SelectedItem;
            if (customer == null)
            {
                return;
            }
            decimal AmountDec;
            decimal.TryParse(tbAmount.Text, out AmountDec);
            if (rbChequing.Checked)
            {
                try
                {
                    customer.WithdrawChequing(AmountDec);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbSavings.Checked)
            {
                try
                {
                    customer.WithdrawSavings(AmountDec);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tbAmount.Clear();
        }
    }
}
