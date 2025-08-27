using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapMakanSystemAdmin
{
    public class PurchaseRule
    {
        //business rules: Can't add no item to the cart and can't add items that would exceed Ewallet balance
        public bool CanAddToCart(decimal itemPrice, int quantity, decimal currentCartTotal, decimal walletBalance)
        {
            if (quantity <= 0) return false;
            if (currentCartTotal + itemPrice > walletBalance) return false;
            return true;
        }
    }
}
