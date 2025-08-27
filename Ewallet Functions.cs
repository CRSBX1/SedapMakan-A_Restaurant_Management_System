using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SedapMakan;

namespace SedapMakanSystemAdmin
{
    public class EwalletBalance
    {
        private decimal _balance;
        private int _walletid;
        private decimal _afterbalance;

        public EwalletBalance()
        {
            _balance = Balance();
            _walletid = WalletID();
            _afterbalance = 0;
        }

        public decimal Balance()
        {
            SqlConnection conn = DatabaseConn.conn;
            SqlCommand command;
            command = new SqlCommand("SELECT Balance From Ewallet WHERE UserID = @id", conn);
            command.Parameters.AddWithValue("@id", Username.id);
            conn.Open();
            _balance = Convert.ToDecimal(command.ExecuteScalar());
            conn.Close();
            return balance;
        }


        public int WalletID()
        {
            SqlConnection conn = DatabaseConn.conn;
            SqlCommand command;
            command = new SqlCommand("SELECT WalletID From Ewallet WHERE UserID = @id", conn);
            command.Parameters.AddWithValue("@id", Username.id);
            conn.Open();
            _walletid = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return _walletid;
        }

        public void Addbalance(decimal addition)
        {
            _balance = balance + addition;
        }

        public void Subtractbalance(decimal subtraction)
        {
            _balance = balance - subtraction;
        }

        public void UpdateBalance(Label AfterBalancelbl)
        {
            _balance = Balance();
            AfterBalancelbl.Text = "Balance: RM " + _balance.ToString();
        }

        public void CalculateAfterBalance(NumericUpDown AmountReqNum, Label AfterBalancelbl, decimal value)
        {
            AmountReqNum.Value = value;
            afterbalance = balance + value;
            AfterBalancelbl.Text = "RM " + afterbalance.ToString();
        }

        //Business rule regarding top-up: the minimum top-up amount request is RM10
        public bool TopUpRule(NumericUpDown AmountReqNum)
        {
            if (AmountReqNum.Value < 10)
            {
                MessageBox.Show("The minimum top-up amount is RM 10");
                return false;
            }

            return true;
        }

        public decimal balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public int walletid
        {
            get { return _walletid; }
            set { _walletid = value; }
        }
        public decimal afterbalance
        {
            get { return _afterbalance; }
            set { _afterbalance = value; }
        }

    }
}
