using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagement
{
    class CustomerAccountManager
    {
        public int customerNo { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public decimal? chequingBalance { get; private set; }
        public decimal? savingsBalance { get; private set; }

        public event EventHandler BalanceChanged; 

        
        public CustomerAccountManager(int CustomerNo, string FirstName, string LastName, decimal? ChequingBalance, decimal? SavingsBalance)
        {
            customerNo = CustomerNo;
            firstName = FirstName;
            lastName = LastName;
            chequingBalance = ChequingBalance;
            savingsBalance = SavingsBalance;
        }

        public virtual void DepositChequing(decimal Amount)
        {
            if (Amount > 0)
            {
                if (chequingBalance == null)
                {
                    chequingBalance = Amount;
                }
                else
                {
                    chequingBalance += Amount;
                }
                OnBalanceChanged(new EventArgs());
            }
        }

        public virtual void DepositSavings(decimal Amount)
        {
            if (Amount > 0)
            {
                if(savingsBalance == null)
                {
                    savingsBalance = Amount;
                }
                else
                {
                    savingsBalance += Amount;
                }
                OnBalanceChanged(new EventArgs());
            }
        }

        public virtual void WithdrawChequing(decimal Amount)
        {
            if (Amount > 0)
            {
                if (chequingBalance != null)
                {
                    if (chequingBalance >= Amount)
                    {
                        chequingBalance -= Amount;
                        OnBalanceChanged(new EventArgs());
                    }
                    else
                    {
                        throw new InvalidOperationException("Amount is greater than balance amount!");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Chequing Balance does not exist!");
                }
            }
            else
            {
                return;
            }

            
        }

        public virtual void WithdrawSavings(decimal Amount)
        {
            if (Amount > 0)
            {
                if (savingsBalance != null)
                {
                    if (savingsBalance >= Amount)
                    {
                        savingsBalance -= Amount;
                        OnBalanceChanged(new EventArgs());
                    }
                    else
                    {
                        throw new InvalidOperationException("Amount is greater than balance amount!");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Savings Balance does not exist!");
                }
            }
            else
            {
                return;
            }
        }

        protected virtual void OnBalanceChanged(EventArgs e)
        {
            if (BalanceChanged != null)
                BalanceChanged(this, e);
        }


        public override string ToString()
        {
            string str = lastName + ", " + firstName;

            if (chequingBalance != null && savingsBalance != null)
            {
                str += " (" + string.Format("{0:C2}", chequingBalance + savingsBalance) + ")";
            }
            else if (chequingBalance != null && savingsBalance == null)
            {
                str += " (" + string.Format("{0:C2}", chequingBalance) + ")";
            }
            else if (savingsBalance != null && chequingBalance == null)
            {
                str += " (" + string.Format("{0:C2}", savingsBalance) + ")";
            }

            return str;
        }
    
    }
}
