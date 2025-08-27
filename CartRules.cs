using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SedapMakan;

namespace SedapMakanSystemAdmin
{
    public class CartAdditionRule
    {
        //Business rule regarding overall price calculation: All item price is calculated by multiplying an item's price with the customer's ordered amount.
        public decimal CalculateOverallPrice(decimal cartprice, System.Windows.Forms.Label cartTotalLabel, List<CustomerMenuItem> customercart)
        {
            cartprice = 0;
            foreach (CustomerMenuItem item in customercart)
            {
                cartprice += item.CalculateTotalPrice();
            }
            cartTotalLabel.Text = "RM " + cartprice.ToString();
            return cartprice;
        }

        //Business rule regarding submitting orders: 1. can't add an order while there are no items in cart
        public bool CartAdd(DataGridView dgv)
        {
            if(dgv.Rows.Count is 0)
            {
                MessageBox.Show("Can't place an order while your cart is empty");
                return false;
            }

            return true;
        }


        //Business rule regarding item addition  in cart: 1. Can't add item amount if balance is insufficient
        public bool ItemAdd(decimal menuprice, decimal finalprice, decimal balance)
        {
            if (menuprice + finalprice > balance)
            {
                MessageBox.Show("Balance is insufficient, can't add this item anymore.");
                return false;
            }

            return true;
        }

        //Business rule regarding item amount edit: 1. can't add an item's amount without selecting it first
        public bool ifempty(string menuname)
        {
            if (string.IsNullOrEmpty(menuname))
            {
                MessageBox.Show("Please select an item to edit first.");
                return false;
            }

            return true;
        }

    }

}
