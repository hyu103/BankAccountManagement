using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BankAccountManagement
{
    public class CustomerAccountManagerDAO
    {
        private SqlConnection m_conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Database=Account;User=sa;Password=access;");
        private SqlConnection Connection { get { return m_conn; } }

        internal CustomerAccountManager CreateCustomer(string FirstName, string LastName)
        {
            SqlCommand sqlcmdCustomer = new SqlCommand("SELECT * FROM Customer", Connection);
            SqlDataAdapter sqldaCustomer = new SqlDataAdapter(sqlcmdCustomer);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(sqldaCustomer);
            DataTable dt = new DataTable();
            DataRow dr;
            int customerId;

            Connection.Open();
            try
            {
                sqldaCustomer.FillSchema(dt, SchemaType.Source);
                dr = dt.NewRow();
                dr["LastName"] = LastName;
                dr["FirstName"] = FirstName;
                dt.Rows.Add(dr);
                sqldaCustomer.Update(dt);

                sqlcmdCustomer.CommandText = "SELECT @@IDENTITY";
                customerId = Convert.ToInt32(sqlcmdCustomer.ExecuteScalar());
                return new CustomerAccountManager(customerId, LastName, FirstName, null, null);
            }
            finally
            {
                Connection.Close();
            }
        }
        internal int NumberOfCustomers()
        {

            SqlCommand sqlcmdCustomer = new SqlCommand("SELECT COUNT(1) AS NumberOfCustomers FROM Customer", Connection);
            Connection.Open();
            int totalCustomers;
            try
            {
                totalCustomers = Convert.ToInt32(sqlcmdCustomer.ExecuteScalar());
            }
            finally
            {
                Connection.Close();
            }
            return totalCustomers;
        }

        internal decimal? TotalOfBalances()
        {
            SqlCommand sqlcmdCustomer = new SqlCommand("SELECT SUM(Balance) As TotalBalance FROM Account", Connection);
            Connection.Open();
            decimal totalBalance = 0;
            try
            {
                if (sqlcmdCustomer.ExecuteScalar() != DBNull.Value)
                {
                    totalBalance = Convert.ToDecimal(sqlcmdCustomer.ExecuteScalar());
                }
            }
            finally
            {
                Connection.Close();
            }
            return totalBalance;
        }
        
        internal List<CustomerAccountManager> LoadAllCustomers()
        {
            List<CustomerAccountManager> customerList = new List<CustomerAccountManager>();
            SqlCommand sqlcmdCustomer = new SqlCommand("SELECT CustomerNumber, LastName, FirstName FROM Customer", Connection);
            SqlDataAdapter da = new SqlDataAdapter(sqlcmdCustomer);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                int CustomerNumber = Convert.ToInt32(dr["CustomerNumber"]);
                string LastName = Convert.ToString(dr["LastName"]);
                string FirstName = Convert.ToString(dr["FirstName"]);
                decimal? chequingBalance = null;
                decimal? savingBalance = null;
                string strSQL = string.Format("SELECT CustomerNumber, AccountType, Balance FROM Account WHERE CustomerNumber={0}", CustomerNumber);
                SqlCommand sqlcmdCustomer1 = new SqlCommand(strSQL, Connection);
                SqlDataAdapter da1 = new SqlDataAdapter(sqlcmdCustomer1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                foreach (DataRow dr1 in dt1.Rows)
                {
                    decimal? balance = Convert.ToDecimal(dr1["Balance"]);
                    char accountType = Convert.ToChar(dr1["AccountType"]);
                    if (accountType == 'C')
                    {
                        chequingBalance = balance;
                    }
                    else if (accountType == 'S')
                    {
                        savingBalance = balance;
                    }

                }
                customerList.Add(new CustomerAccountManager(CustomerNumber, LastName, FirstName, chequingBalance, savingBalance));
            }
            return customerList;
        }
   
        internal void SaveCustomer(CustomerAccountManager CustomerAccount)
        {
            decimal? chequing = CustomerAccount.chequingBalance;
            decimal? saving = CustomerAccount.savingsBalance;

            if (chequing != null)
            {
                SqlCommand sqlcmdCustomer = new SqlCommand("SELECT CustomerNumber, AccountType, Balance FROM Account WHERE CustomerNumber = @pCustomerNumber AND AccountType='C'", Connection);
                SqlDataAdapter sqldaCustomer = new SqlDataAdapter(sqlcmdCustomer);
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder(sqldaCustomer);
                DataTable dt = new DataTable();

                sqlcmdCustomer.Parameters.AddWithValue("pCustomerNumber", CustomerAccount.customerNo);

                sqldaCustomer.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    dr["Balance"] = chequing;
                    sqldaCustomer.Update(dt);
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    dr["CustomerNumber"] = CustomerAccount.customerNo;
                    dr["AccountType"] = 'C';
                    dr["Balance"] = chequing;
                    dt.Rows.Add(dr);
                    sqldaCustomer.Update(dt);
                }
            }

            if (saving != null)
            {
                SqlCommand sqlcmdCustomer = new SqlCommand("SELECT CustomerNumber, AccountType, Balance FROM Account WHERE CustomerNumber = @pCustomerNumber AND AccountType='S'", Connection);
                SqlDataAdapter sqldaCustomer = new SqlDataAdapter(sqlcmdCustomer);
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder(sqldaCustomer);
                DataTable dt = new DataTable();

                sqlcmdCustomer.Parameters.AddWithValue("pCustomerNumber", CustomerAccount.customerNo);

                sqldaCustomer.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    dr["Balance"] = saving;
                    sqldaCustomer.Update(dt);
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    dr["CustomerNumber"] = CustomerAccount.customerNo;
                    dr["AccountType"] = 'S';
                    dr["Balance"] = saving;
                    dt.Rows.Add(dr);
                    sqldaCustomer.Update(dt);
                }
            }
        }
    }
}
